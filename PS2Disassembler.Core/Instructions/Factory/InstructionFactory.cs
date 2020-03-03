using PS2Disassembler.Core.Instructions.Immediate;
using PS2Disassembler.Core.Instructions.Immediate.Branch;
using PS2Disassembler.Core.Instructions.Immediate.C790;
using PS2Disassembler.Core.Instructions.Jump;
using PS2Disassembler.Core.Instructions.Register;
using PS2Disassembler.Core.Instructions.Register.C790;
using PS2Disassembler.Core.Parser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using MULT = PS2Disassembler.Core.Instructions.Register.MULT;
using MULTU = PS2Disassembler.Core.Instructions.Register.MULTU;

namespace PS2Disassembler.Core.Instructions.Factory
{
    public class InstructionFactory : IInstructionFactory
    {
        private Dictionary<string, InstructionType> _instructionTypes;
        private Dictionary<string, Type> _instructionOpCodes;
        private Dictionary<string, Type> _regimmCodes;
        private Dictionary<string, Type> _specialCodes;
        private Dictionary<string, Type> _mmiCodes;
        private Dictionary<string, Type> _mmi0Codes;
        private Dictionary<string, Type> _mmi1Codes;
        private Dictionary<string, Type> _mmi2Codes;
        private Dictionary<string, Type> _mmi3Codes;
        private IInstructionParser _instructionParser;

        public InstructionFactory()
        {
            InitializeDictionaries();
            _instructionParser = new InstructionParser();
        }

        public object CreateInstruction(int input)
        {
            if (input == 0)
                return new Nop();

            var opBin = Convert.ToString((input >> 26) & 0x3F, 2);

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
                        var funct = Convert.ToString(input & 0x3F, 2);
                        instructionClassType = _specialCodes[funct];
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
                        var mmiNr = Convert.ToString(input & 0x3F, 2);

                        // For MMI0, MMI1, MMI2 and MMI3, the opcode is in the SA part of the instruction
                        var mmiOpCode = Convert.ToString((input >> 6) & 0x1F, 2);

                        switch (mmiNr)
                        {
                            case "001000": // MMI0
                                instructionClassType = _mmi0Codes[mmiOpCode];
                                break;

                            case "101000": // MMI1
                                instructionClassType = _mmi1Codes[mmiOpCode];
                                break;

                            case "001001": // MMI2
                                instructionClassType = _mmi2Codes[mmiOpCode];
                                break;

                            case "101001": // MMI3
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
            _instructionTypes = new Dictionary<string, InstructionType>()
            {
                {"0", InstructionType.Register}, // SPECIAL
                {"1000", InstructionType.Immediate}, // ADDI
                {"1001", InstructionType.Immediate}, // ADDIU
                {"1100", InstructionType.Immediate}, // ANDI
                {"100", InstructionType.Immediate}, // BEQ
                {"10100", InstructionType.Immediate}, // BEQL
                {"1", InstructionType.Regimm}, // BGEZ,BGEZAL,BGEZALL,BGEZL,BLTZ,BLTZAL,BLTZALL,BLTZL,TEQI,TGEI,TGEIU,TLTI,TLTIU,TNEI
                {"111", InstructionType.Immediate}, // BGTZ
                {"10111", InstructionType.Immediate}, // BGTZL
                {"110", InstructionType.Immediate}, // BLEZ
                {"10110", InstructionType.Immediate}, // BLEZL
                {"101", InstructionType.Immediate}, // BNE
                {"10101", InstructionType.Immediate}, // BNEL
                {"11000", InstructionType.Immediate}, // DADDI
                {"11001", InstructionType.Immediate}, // DADDIU
                {"10", InstructionType.Jump}, // J
                {"11", InstructionType.Jump}, // JAL
                {"100000", InstructionType.Immediate}, // LB
                {"100100", InstructionType.Immediate}, // LBU
                {"110111", InstructionType.Immediate}, // LD
                {"11010", InstructionType.Immediate}, // LDL
                {"11011", InstructionType.Immediate}, // LDR
                {"100001", InstructionType.Immediate}, // LH
                {"100101", InstructionType.Immediate}, // LHU
                {"1111", InstructionType.Immediate}, // LUI
                {"100011", InstructionType.Immediate}, // LW
                {"100010", InstructionType.Immediate}, // LWL
                {"100110", InstructionType.Immediate}, // LWR
                {"100111", InstructionType.Immediate}, // LWU
                {"1101", InstructionType.Immediate}, // ORI
                {"110011", InstructionType.Immediate}, // PREF
                {"101000", InstructionType.Immediate}, // SB
                {"111111", InstructionType.Immediate}, // SD
                {"101100", InstructionType.Immediate}, // SDL
                {"101101", InstructionType.Immediate}, // SDR
                {"101001", InstructionType.Immediate}, // SH
                {"1010", InstructionType.Immediate}, // SLTI
                {"1011", InstructionType.Immediate}, // SLTIU
                {"101011", InstructionType.Immediate}, // SW
                {"101010", InstructionType.Immediate}, // SWL
                {"101110", InstructionType.Immediate}, // SWR
                {"1110", InstructionType.Immediate}, // XORI

                // C790 specific
                {"11100", InstructionType.MMI}, // MMI (Register)
                {"11110", InstructionType.Immediate}, // LQ
                {"11111", InstructionType.Immediate}, // SQ
            };

            _instructionOpCodes = new Dictionary<string, Type>()
            {
                //{"000000", typeof(SPECIAL)},
                {"1000", typeof(ADDI)},
                {"1001", typeof(ADDIU)},
                {"1100", typeof(ANDI)},
                {"100", typeof(BEQ)},
                {"10100", typeof(BEQL)},
                //{"000001", typeof(REGIMM)},
                {"111", typeof(BGTZ)},
                {"10111", typeof(BGTZL)},
                {"110", typeof(BLEZ)},
                {"10110", typeof(BLEZL)},
                {"101", typeof(BNE)},
                {"10101", typeof(BNEL)},
                {"11000", typeof(DADDI)},
                {"11001", typeof(DADDIU)},
                {"10", typeof(J)},
                {"11", typeof(JAL)},
                {"100000", typeof(LB)},
                {"100100", typeof(LBU)},
                {"110111", typeof(LD)},
                {"11010", typeof(LDL)},
                {"11011", typeof(LDR)},
                {"100001", typeof(LH)},
                {"100101", typeof(LHU)},
                {"1111", typeof(LUI)},
                {"100011", typeof(LW)},
                {"100010", typeof(LWL)},
                {"100110", typeof(LWR)},
                {"100111", typeof(LWU)},
                {"1101", typeof(ORI)},
                {"110011", typeof(PREF)},
                {"101000", typeof(SB)},
                {"111111", typeof(SD)},
                {"101100", typeof(SDL)},
                {"101101", typeof(SDR)},
                {"101001", typeof(SH)},
                {"1010", typeof(SLTI)},
                {"1011", typeof(SLTIU)},
                {"101011", typeof(SW)},
                {"101010", typeof(SWL)},
                {"101110", typeof(SWR)},
                {"1110", typeof(XORI)},

                // C790 specific
                {"11110", typeof(LQ)},
                {"11111", typeof(SQ)},
            };

            _regimmCodes = new Dictionary<string, Type>()
            {
                {"1", typeof(BGEZ)},
                {"10001", typeof(BGEZAL)},
                {"10011", typeof(BGEZALL)},
                {"11", typeof(BGEZL)},
                {"0", typeof(BLTZ)},
                {"10000", typeof(BLTZAL)},
                {"10010", typeof(BLTZALL)},
                {"10", typeof(BLTZL)},
                {"1100", typeof(TEQI)},
                {"1000", typeof(TGEI)},
                {"1001", typeof(TGEIU)},
                {"1010", typeof(TLTI)},
                {"1011", typeof(TLTIU)},
                {"1110", typeof(TNEI)},
                {"11000", typeof(MTSAB)},
                {"11001", typeof(MTSAH)}
            };

            _specialCodes = new Dictionary<string, Type>()
            {
                {"100000", typeof(ADD)},
                {"100001", typeof(ADDU)},
                {"100100", typeof(AND)},
                {"1101", typeof(BREAK)},
                {"101100", typeof(DADD)},
                {"101101", typeof(DADDU)},
                {"11010", typeof(DIV)},
                {"11011", typeof(DIVU)},
                {"111000", typeof(DSLL)},
                {"111100", typeof(DSLL32)},
                {"10100", typeof(DSLLV)},
                {"111011", typeof(DSRA)},
                {"111111", typeof(DSRA32)},
                {"10111", typeof(DSRAV)},
                {"111010", typeof(DSRL)},
                {"111110", typeof(DSRL32)},
                {"10110", typeof(DSRLV)},
                {"101110", typeof(DSUB)},
                {"101111", typeof(DSUBU)},
                {"1001", typeof(JALR)},
                {"1000", typeof(JR)},
                {"10000", typeof(MFHI)},
                {"10010", typeof(MFLO)},
                {"1011", typeof(MOVN)},
                {"1010", typeof(MOVZ)},
                {"10001", typeof(MTHI)},
                {"10011", typeof(MTLO)},
                {"11000", typeof(MULT)},
                {"11001", typeof(MULTU)},
                {"100111", typeof(NOR)},
                {"100101", typeof(OR)},
                {"0", typeof(SLL)},
                {"100", typeof(SLLV)},
                {"101010", typeof(SLT)},
                {"101011", typeof(SLTU)},
                {"11", typeof(SRA)},
                {"111", typeof(SRAV)},
                {"10", typeof(SRL)},
                {"110", typeof(SRLV)},
                {"100010", typeof(SUB)},
                {"100011", typeof(SUBU)},
                {"1111", typeof(SYNC)},
                {"1100", typeof(SYSCALL)},
                {"110100", typeof(TEQ)},
                {"110000", typeof(TGE)},
                {"110001", typeof(TGEU)},
                {"110010", typeof(TLT)},
                {"110011", typeof(TLTU)},
                {"110110", typeof(TNE)},
                {"100110", typeof(XOR)},

                // C790 specific
                {"101000", typeof(MFSA)},
                {"101001", typeof(MTSA)}
            };

            _mmiCodes = new Dictionary<string, Type>()
            {
                {"11010", typeof(DIV1)},
                {"11011", typeof(DIVU1)},
                {"0", typeof(MADD)},
                {"100000", typeof(MADD1)},
                {"01", typeof(MADDU)},
                {"100001", typeof(MADDU1)},
                {"10000", typeof(MFHI1)},
                {"10010", typeof(MFLO1)},
                {"10001", typeof(MTHI1)},
                {"10011", typeof(MTLO1)},
                {"11000", typeof(MULT1)},
                {"11001", typeof(MULTU1)},
                {"100", typeof(PLZCW)},
                {"110000", typeof(PMFHLfmt)},
                {"110001", typeof(PMTHLfmt)},
                {"110100", typeof(PSLLH)},
                {"111100", typeof(PSLLW)},
                {"110111", typeof(PSRAH)},
                {"111111", typeof(PSRAW)},
                {"110110", typeof(PSRLH)},
                {"111110", typeof(PSRLW)},
            };

            _mmi0Codes = new Dictionary<string, Type>()
            {
                
                {"1000", typeof(PADDB)},
                {"100", typeof(PADDH)},
                {"11000", typeof(PADDSB)},
                {"10100", typeof(PADDSH)},
                {"10000", typeof(PADDSW)},
                {"0", typeof(PADDW)},
                {"1010", typeof(PCGTB)},
                {"110", typeof(PCGTH)},
                {"10", typeof(PCGTW)},
                {"11110", typeof(PEXT5)},
                {"11010", typeof(PEXTLB)},
                {"10110", typeof(PEXTLH)},
                {"10010", typeof(PEXTLW)},
                {"111", typeof(PMAXH)},
                {"11", typeof(PMAXW)},
                {"11111", typeof(PPAC5)},
                {"11011", typeof(PPACB)},
                {"10111", typeof(PPACH)},
                {"10011", typeof(PPACW)},
                {"1001", typeof(PSUBB)},
                {"101", typeof(PSUBH)},
                {"11001", typeof(PSUBSB)},
                {"10101", typeof(PSUBSH)},
                {"10001", typeof(PSUBSW)},
                {"1", typeof(PSUBW)}
            };

            _mmi1Codes = new Dictionary<string, Type>()
            {
                {"10", typeof(PCEQW)},
                {"110", typeof(PCEQH)},
                {"1010", typeof(PCEQB)},
                {"100", typeof(PADSBH)},
                {"10000", typeof(PADDUW)},
                {"10100", typeof(PADDUH)},
                {"11000", typeof(PADDUB)},
                {"101", typeof(PABSH)},
                {"1", typeof(PABSW)},
                {"11010", typeof(PEXTUB)},
                {"10110", typeof(PEXTUH)},
                {"10010", typeof(PEXTUW)},
                {"111", typeof(PMINH)},
                {"011", typeof(PMINW)},
                {"11001", typeof(PSUBUB)},
                {"10101", typeof(PSUBUH)},
                {"10001", typeof(PSUBUW)},
                {"11011", typeof(QFSRV)}
            };

            _mmi2Codes = new Dictionary<string, Type>()
            {
                {"11110", typeof(PEXEW)},
                {"11010", typeof(PEXEH)},
                {"1101", typeof(PDIVW)},
                {"11101", typeof(PDIVBW)},
                {"1110", typeof(PCPYLD)},
                {"10010", typeof(PAND)},
                {"10001", typeof(PHMADH)},
                {"10101", typeof(PHMSBH)},
                {"1010", typeof(PINTH)},
                {"10000", typeof(PMADDH)},
                {"0", typeof(PMADDW)},
                {"1000", typeof(PMFHI)},
                {"1001", typeof(PMFLO)},
                {"10100", typeof(PMSUBH)},
                {"100", typeof(PMSUBW)},
                {"11100", typeof(PMULTH)},
                {"1100", typeof(PMULTW)},
                {"11011", typeof(PREVH)},
                {"11111", typeof(PROT3W)},
                {"10", typeof(PSLLVW)},
                {"11", typeof(PSRLVW)},
                {"10011", typeof(PXOR)}
            };

            _mmi3Codes = new Dictionary<string, Type>()
            {
                {"11110", typeof(PEXCW)},
                {"11010", typeof(PEXCH)},
                {"1101", typeof(PDIVUW)},
                {"1110", typeof(PCPYUD)},
                {"11011", typeof(PCPYH)},
                {"1010", typeof(PINTEH)},
                {"0", typeof(PMADDUW)},
                {"1000", typeof(PMTHI)},
                {"1001", typeof(PMTLO)},
                {"1100", typeof(PMULTUW)},
                {"10011", typeof(PNOR)},
                {"10010", typeof(POR)},
                {"11", typeof(PSRAVW)}
            };
        }
    }
}
