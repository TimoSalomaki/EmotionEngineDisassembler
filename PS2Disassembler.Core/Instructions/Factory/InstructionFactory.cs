using PS2Disassembler.Core.Instructions.Immediate;
using PS2Disassembler.Core.Instructions.Immediate.Branch;
using PS2Disassembler.Core.Instructions.Immediate.C790;
using PS2Disassembler.Core.Instructions.Jump;
using PS2Disassembler.Core.Instructions.Register;
using PS2Disassembler.Core.Instructions.Register.C790;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace PS2Disassembler.Core.Instructions.Factory
{
    public class InstructionFactory : IInstructionFactory
    {
        private Dictionary<int, InstructionType> _instructionTypes;
        private Dictionary<int, Type> _instructionOpCodes;
        private Dictionary<int, Type> _regimmCodes;
        private Dictionary<int, Type> _specialCodes;
        private Dictionary<int, Type> _mmiCodes;
        private Dictionary<int, Type> _mmi0Codes;
        private Dictionary<int, Type> _mmi1Codes;
        private Dictionary<int, Type> _mmi2Codes;
        private Dictionary<int, Type> _mmi3Codes;

        public InstructionFactory()
        {
            InitializeDictionaries();
        }

        public object CreateInstruction(int input)
        {
            if (input == 0)
                return new Nop();

            var opBin = (input >> 26) & 0x3F;

            Type instructionClassType = default;
            var args = new object[]{};

            try
            {
                switch (_instructionTypes[opBin])
                {
                    case InstructionType.Immediate:
                        instructionClassType = _instructionOpCodes[opBin];
                        args = new object[]
                        {
                            (input >> 21) & 0x1F,
                            (input >> 16) & 0x1F,
                            input & 0xFFFF,
                        };
                        break;
                    case InstructionType.Jump:
                        instructionClassType = _instructionOpCodes[opBin];
                        args = new object[]
                        {
                            input & 0x3FFFFFF,
                        };
                        break;

                    case InstructionType.Regimm:
                        instructionClassType = _regimmCodes[opBin];
                        args = new object[]
                        {
                            (input >> 21) & 0x1F,
                            (input >> 16) & 0x1F,
                            input & 0xFFFF,
                        };
                        break;

                    case InstructionType.Register:
                        //var funct = Convert.ToString(input & 0x3F, 2);
                        var funct = input & 0x3F;
                        instructionClassType = _specialCodes[funct];

                        if (instructionClassType == typeof(Register.C790.MULT))
                        {
                            if (((input >> 6) & 0x1F) == 0)
                            {
                                instructionClassType = typeof(Register.MULT);
                            }
                        }

                        else if (instructionClassType == typeof(Register.C790.MULTU))
                        {
                            if (((input >> 6) & 0x1F) == 0)
                            {
                                instructionClassType = typeof(Register.MULTU);
                            }
                        }

                        args = new object[]
                        {
                            (input >> 21) & 0x1F,
                            (input >> 16) & 0x1F,
                            (input >> 11) & 0x1F,
                            (input >> 6) & 0x1F,
                            input & 0x1F,
                        };
                        break;

                    case InstructionType.MMI:
                        var mmiNr = input & 0x3F;

                        // For MMI0, MMI1, MMI2 and MMI3, the opcode is in the SA part of the instruction
                        var mmiOpCode = (input >> 6) & 0x1F;

                        switch (mmiNr)
                        {
                            case 8: // MMI0
                                instructionClassType = _mmi0Codes[mmiOpCode];
                                break;

                            case 40: // MMI1
                                instructionClassType = _mmi1Codes[mmiOpCode];
                                break;

                            case 9: // MMI2
                                instructionClassType = _mmi2Codes[mmiOpCode];
                                break;

                            case 41: // MMI3
                                instructionClassType = _mmi3Codes[mmiOpCode];
                                break;

                            default: // MMI
                                instructionClassType = _mmiCodes[mmiNr];
                                break;
                        }
                        
                        args = new object[]
                        {
                            (input >> 21) & 0x1F,
                            (input >> 16) & 0x1F,
                            (input >> 11) & 0x1F,
                            (input >> 6) & 0x1F,
                            input & 0x1F,
                        };
                        break;
                }
            }

            catch (KeyNotFoundException)
            {
                return new Nop();
            }

            var newInstance = GetInstance(instructionClassType, args);

            return newInstance;
        }

        public object GetInstance(Type typeToCreate, object[] args)
        {
            return Activator.CreateInstance(typeToCreate, BindingFlags.CreateInstance, null, args, CultureInfo.CurrentCulture);
        }

        private void InitializeDictionaries()
        {
            _instructionTypes = new Dictionary<int, InstructionType>()
            {
                {0, InstructionType.Register}, // SPECIAL
                {8, InstructionType.Immediate}, // ADDI
                {9, InstructionType.Immediate}, // ADDIU
                {12, InstructionType.Immediate}, // ANDI
                {4, InstructionType.Immediate}, // BEQ
                {20, InstructionType.Immediate}, // BEQL
                {1, InstructionType.Regimm}, // BGEZ,BGEZAL,BGEZALL,BGEZL,BLTZ,BLTZAL,BLTZALL,BLTZL,TEQI,TGEI,TGEIU,TLTI,TLTIU,TNEI
                {7, InstructionType.Immediate}, // BGTZ
                {23, InstructionType.Immediate}, // BGTZL
                {6, InstructionType.Immediate}, // BLEZ
                {22, InstructionType.Immediate}, // BLEZL
                {5, InstructionType.Immediate}, // BNE
                {21, InstructionType.Immediate}, // BNEL
                {24, InstructionType.Immediate}, // DADDI
                {25, InstructionType.Immediate}, // DADDIU
                {2, InstructionType.Jump}, // J
                {3, InstructionType.Jump}, // JAL
                {32, InstructionType.Immediate}, // LB
                {36, InstructionType.Immediate}, // LBU
                {55, InstructionType.Immediate}, // LD
                {26, InstructionType.Immediate}, // LDL
                {27, InstructionType.Immediate}, // LDR
                {33, InstructionType.Immediate}, // LH
                {37, InstructionType.Immediate}, // LHU
                {15, InstructionType.Immediate}, // LUI
                {35, InstructionType.Immediate}, // LW
                {34, InstructionType.Immediate}, // LWL
                {38, InstructionType.Immediate}, // LWR
                {39, InstructionType.Immediate}, // LWU
                {13, InstructionType.Immediate}, // ORI
                {51, InstructionType.Immediate}, // PREF
                {40, InstructionType.Immediate}, // SB
                {63, InstructionType.Immediate}, // SD
                {44, InstructionType.Immediate}, // SDL
                {45, InstructionType.Immediate}, // SDR
                {41, InstructionType.Immediate}, // SH
                {10, InstructionType.Immediate}, // SLTI
                {11, InstructionType.Immediate}, // SLTIU
                {43, InstructionType.Immediate}, // SW
                {42, InstructionType.Immediate}, // SWL
                {46, InstructionType.Immediate}, // SWR
                {14, InstructionType.Immediate}, // XORI

                // C790 specific
                {28, InstructionType.MMI}, // MMI (Register)
                {30, InstructionType.Immediate}, // LQ
                {31, InstructionType.Immediate}, // SQ
            };

            _instructionOpCodes = new Dictionary<int, Type>()
            {
                //{0, typeof(SPECIAL)},
                {8, typeof(ADDI)},
                {9, typeof(ADDIU)},
                {12, typeof(ANDI)},
                {4, typeof(BEQ)},
                {20, typeof(BEQL)},
                //{1, typeof(REGIMM)},
                {7, typeof(BGTZ)},
                {23, typeof(BGTZL)},
                {6, typeof(BLEZ)},
                {22, typeof(BLEZL)},
                {5, typeof(BNE)},
                {21, typeof(BNEL)},
                {24, typeof(DADDI)},
                {25, typeof(DADDIU)},
                {2, typeof(J)},
                {3, typeof(JAL)},
                {32, typeof(LB)},
                {36, typeof(LBU)},
                {55, typeof(LD)},
                {26, typeof(LDL)},
                {27, typeof(LDR)},
                {33, typeof(LH)},
                {37, typeof(LHU)},
                {15, typeof(LUI)},
                {35, typeof(LW)},
                {34, typeof(LWL)},
                {38, typeof(LWR)},
                {39, typeof(LWU)},
                {13, typeof(ORI)},
                {51, typeof(PREF)},
                {40, typeof(SB)},
                {63, typeof(SD)},
                {44, typeof(SDL)},
                {45, typeof(SDR)},
                {41, typeof(SH)},
                {10, typeof(SLTI)},
                {11, typeof(SLTIU)},
                {43, typeof(SW)},
                {42, typeof(SWL)},
                {46, typeof(SWR)},
                {14, typeof(XORI)},

                // C790 specific
                {30, typeof(LQ)},
                {31, typeof(SQ)},
            };

            _regimmCodes = new Dictionary<int, Type>()
            {
                {1, typeof(BGEZ)},
                {17, typeof(BGEZAL)},
                {19, typeof(BGEZALL)},
                {3, typeof(BGEZL)},
                {0, typeof(BLTZ)},
                {16, typeof(BLTZAL)},
                {18, typeof(BLTZALL)},
                {2, typeof(BLTZL)},
                {12, typeof(TEQI)},
                {8, typeof(TGEI)},
                {9, typeof(TGEIU)},
                {10, typeof(TLTI)},
                {11, typeof(TLTIU)},
                {14, typeof(TNEI)},
                {24, typeof(MTSAB)},
                {25, typeof(MTSAH)}
            };

            _specialCodes = new Dictionary<int, Type>()
            {
                {32, typeof(ADD)},
                {33, typeof(ADDU)},
                {36, typeof(AND)},
                {13, typeof(BREAK)},
                {44, typeof(DADD)},
                {45, typeof(DADDU)},
                {26, typeof(DIV)},
                {27, typeof(DIVU)},
                {56, typeof(DSLL)},
                {60, typeof(DSLL32)},
                {20, typeof(DSLLV)},
                {59, typeof(DSRA)},
                {63, typeof(DSRA32)},
                {23, typeof(DSRAV)},
                {58, typeof(DSRL)},
                {62, typeof(DSRL32)},
                {22, typeof(DSRLV)},
                {46, typeof(DSUB)},
                {47, typeof(DSUBU)},
                {9, typeof(JALR)},
                {8, typeof(JR)},
                {16, typeof(MFHI)},
                {18, typeof(MFLO)},
                {11, typeof(MOVN)},
                {10, typeof(MOVZ)},
                {17, typeof(MTHI)},
                {19, typeof(MTLO)},
                {39, typeof(NOR)},
                {37, typeof(OR)},
                {0, typeof(SLL)},
                {4, typeof(SLLV)},
                {42, typeof(SLT)},
                {43, typeof(SLTU)},
                {3, typeof(SRA)},
                {7, typeof(SRAV)},
                {2, typeof(SRL)},
                {6, typeof(SRLV)},
                {34, typeof(SUB)},
                {35, typeof(SUBU)},
                {15, typeof(SYNC)},
                {12, typeof(SYSCALL)},
                {52, typeof(TEQ)},
                {48, typeof(TGE)},
                {49, typeof(TGEU)},
                {50, typeof(TLT)},
                {51, typeof(TLTU)},
                {54, typeof(TNE)},
                {38, typeof(XOR)},

                // C790 specific
                {40, typeof(MFSA)},
                {41, typeof(MTSA)},
                {24, typeof(Register.C790.MULT)},
                {25, typeof(Register.C790.MULTU)}
            };

            _mmiCodes = new Dictionary<int, Type>()
            {
                {26, typeof(DIV1)},
                {27, typeof(DIVU1)},
                {0, typeof(MADD)},
                {32, typeof(MADD1)},
                {1, typeof(MADDU)},
                {33, typeof(MADDU1)},
                {16, typeof(MFHI1)},
                {18, typeof(MFLO1)},
                {17, typeof(MTHI1)},
                {19, typeof(MTLO1)},
                {24, typeof(MULT1)},
                {25, typeof(MULTU1)},
                {4, typeof(PLZCW)},
                {48, typeof(PMFHLfmt)},
                {49, typeof(PMTHLfmt)},
                {52, typeof(PSLLH)},
                {60, typeof(PSLLW)},
                {55, typeof(PSRAH)},
                {63, typeof(PSRAW)},
                {54, typeof(PSRLH)},
                {62, typeof(PSRLW)},
            };

            _mmi0Codes = new Dictionary<int, Type>()
            {

                {8, typeof(PADDB)},
                {4, typeof(PADDH)},
                {24, typeof(PADDSB)},
                {20, typeof(PADDSH)},
                {16, typeof(PADDSW)},
                {0, typeof(PADDW)},
                {10, typeof(PCGTB)},
                {6, typeof(PCGTH)},
                {2, typeof(PCGTW)},
                {30, typeof(PEXT5)},
                {26, typeof(PEXTLB)},
                {22, typeof(PEXTLH)},
                {18, typeof(PEXTLW)},
                {7, typeof(PMAXH)},
                {3, typeof(PMAXW)},
                {31, typeof(PPAC5)},
                {27, typeof(PPACB)},
                {23, typeof(PPACH)},
                {19, typeof(PPACW)},
                {9, typeof(PSUBB)},
                {5, typeof(PSUBH)},
                {25, typeof(PSUBSB)},
                {21, typeof(PSUBSH)},
                {17, typeof(PSUBSW)},
                {1, typeof(PSUBW)}
            };

            _mmi1Codes = new Dictionary<int, Type>()
            {
                {2, typeof(PCEQW)},
                {6, typeof(PCEQH)},
                {10, typeof(PCEQB)},
                {4, typeof(PADSBH)},
                {16, typeof(PADDUW)},
                {20, typeof(PADDUH)},
                {24, typeof(PADDUB)},
                {5, typeof(PABSH)},
                {1, typeof(PABSW)},
                {26, typeof(PEXTUB)},
                {22, typeof(PEXTUH)},
                {18, typeof(PEXTUW)},
                {7, typeof(PMINH)},
                {3, typeof(PMINW)},
                {25, typeof(PSUBUB)},
                {21, typeof(PSUBUH)},
                {17, typeof(PSUBUW)},
                {27, typeof(QFSRV)}
            };

            _mmi2Codes = new Dictionary<int, Type>()
            {
                {30, typeof(PEXEW)},
                {26, typeof(PEXEH)},
                {13, typeof(PDIVW)},
                {29, typeof(PDIVBW)},
                {14, typeof(PCPYLD)},
                {18, typeof(PAND)},
                {17, typeof(PHMADH)},
                {21, typeof(PHMSBH)},
                {10, typeof(PINTH)},
                {16, typeof(PMADDH)},
                {0, typeof(PMADDW)},
                {8, typeof(PMFHI)},
                {9, typeof(PMFLO)},
                {20, typeof(PMSUBH)},
                {4, typeof(PMSUBW)},
                {28, typeof(PMULTH)},
                {12, typeof(PMULTW)},
                {27, typeof(PREVH)},
                {31, typeof(PROT3W)},
                {2, typeof(PSLLVW)},
                {3, typeof(PSRLVW)},
                {19, typeof(PXOR)}
            };

            _mmi3Codes = new Dictionary<int, Type>()
            {
                {30, typeof(PEXCW)},
                {26, typeof(PEXCH)},
                {13, typeof(PDIVUW)},
                {14, typeof(PCPYUD)},
                {27, typeof(PCPYH)},
                {10, typeof(PINTEH)},
                {0, typeof(PMADDUW)},
                {8, typeof(PMTHI)},
                {9, typeof(PMTLO)},
                {12, typeof(PMULTUW)},
                {19, typeof(PNOR)},
                {18, typeof(POR)},
                {3, typeof(PSRAVW)}
            };

        }
    }
}
