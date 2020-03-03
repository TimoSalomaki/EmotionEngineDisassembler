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

            var binary = Convert.ToString(input, 2);

            if (binary.Length < 32) // Make sure we always have 32 bits with leading zeros
                binary = binary.PadLeft(32, '0');

            var opBin = _instructionParser.GetBinary(binary, 0, 6);
            
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
                            _instructionParser.GetBinary(binary, 6, 5), // RS
                            _instructionParser.GetBinary(binary, 11, 5), // RT
                            Convert.ToInt16(_instructionParser.GetBinary(binary, 16, 16), 2) // Immediate
                        };
                        break;
                    case InstructionType.Jump:
                        instructionClassType = _instructionOpCodes[opBin];
                        args = new object[]
                        {
                            _instructionParser.GetBinary(binary, 6, 26) // Target
                        };
                        break;

                    case InstructionType.Regimm:
                        instructionClassType = _regimmCodes[opBin];
                        args = new object[]
                        {
                            _instructionParser.GetBinary(binary, 6, 5), // RS
                            _instructionParser.GetBinary(binary, 11, 5), // RT
                            Convert.ToInt16(_instructionParser.GetBinary(binary, 16, 16), 2) // Offset (Immediate)
                        };
                        break;

                    case InstructionType.Register:
                        var funct = _instructionParser.GetBinary(binary, 26, 6);
                        instructionClassType = _specialCodes[funct];
                        args = new object[]
                        {
                            _instructionParser.GetBinary(binary, 6, 5), // RS
                            _instructionParser.GetBinary(binary, 11, 5), // RT
                            _instructionParser.GetBinary(binary, 16, 5), // RD
                            _instructionParser.GetBinary(binary, 21, 5), // SA
                            _instructionParser.GetBinary(binary, 26, 5), // Funct
                        };
                        break;

                    case InstructionType.MMI:
                        var mmiNr = _instructionParser.GetBinary(binary, 26, 6);

                        // For MMI0, MMI1, MMI2 and MMI3, the opcode is in the SA part of the instruction
                        var mmiOpCode = _instructionParser.GetBinary(binary, 21, 5);

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
                            _instructionParser.GetBinary(binary, 6, 5), // RS
                            _instructionParser.GetBinary(binary, 11, 5), // RT
                            _instructionParser.GetBinary(binary, 16, 5), // RD
                            _instructionParser.GetBinary(binary, 21, 5), // SA
                            _instructionParser.GetBinary(binary, 26, 5), // Funct
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
                {"000000", InstructionType.Register}, // SPECIAL
                {"001000", InstructionType.Immediate}, // ADDI
                {"001001", InstructionType.Immediate}, // ADDIU
                {"001100", InstructionType.Immediate}, // ANDI
                {"000100", InstructionType.Immediate}, // BEQ
                {"010100", InstructionType.Immediate}, // BEQL
                {"000001", InstructionType.Regimm}, // BGEZ,BGEZAL,BGEZALL,BGEZL,BLTZ,BLTZAL,BLTZALL,BLTZL,TEQI,TGEI,TGEIU,TLTI,TLTIU,TNEI
                {"000111", InstructionType.Immediate}, // BGTZ
                {"010111", InstructionType.Immediate}, // BGTZL
                {"000110", InstructionType.Immediate}, // BLEZ
                {"010110", InstructionType.Immediate}, // BLEZL
                {"000101", InstructionType.Immediate}, // BNE
                {"010101", InstructionType.Immediate}, // BNEL
                {"011000", InstructionType.Immediate}, // DADDI
                {"011001", InstructionType.Immediate}, // DADDIU
                {"000010", InstructionType.Jump}, // J
                {"000011", InstructionType.Jump}, // JAL
                {"100000", InstructionType.Immediate}, // LB
                {"100100", InstructionType.Immediate}, // LBU
                {"110111", InstructionType.Immediate}, // LD
                {"011010", InstructionType.Immediate}, // LDL
                {"011011", InstructionType.Immediate}, // LDR
                {"100001", InstructionType.Immediate}, // LH
                {"100101", InstructionType.Immediate}, // LHU
                {"001111", InstructionType.Immediate}, // LUI
                {"100011", InstructionType.Immediate}, // LW
                {"100010", InstructionType.Immediate}, // LWL
                {"100110", InstructionType.Immediate}, // LWR
                {"100111", InstructionType.Immediate}, // LWU
                {"001101", InstructionType.Immediate}, // ORI
                {"110011", InstructionType.Immediate}, // PREF
                {"101000", InstructionType.Immediate}, // SB
                {"111111", InstructionType.Immediate}, // SD
                {"101100", InstructionType.Immediate}, // SDL
                {"101101", InstructionType.Immediate}, // SDR
                {"101001", InstructionType.Immediate}, // SH
                {"001010", InstructionType.Immediate}, // SLTI
                {"001011", InstructionType.Immediate}, // SLTIU
                {"101011", InstructionType.Immediate}, // SW
                {"101010", InstructionType.Immediate}, // SWL
                {"101110", InstructionType.Immediate}, // SWR
                {"001110", InstructionType.Immediate}, // XORI

                // C790 specific
                {"011100", InstructionType.MMI}, // MMI (Register)
                {"011110", InstructionType.Immediate}, // LQ
                {"011111", InstructionType.Immediate}, // SQ
            };

            _instructionOpCodes = new Dictionary<string, Type>()
            {
                //{"000000", typeof(SPECIAL)},
                {"001000", typeof(ADDI)},
                {"001001", typeof(ADDIU)},
                {"001100", typeof(ANDI)},
                {"000100", typeof(BEQ)},
                {"010100", typeof(BEQL)},
                //{"000001", typeof(REGIMM)},
                {"000111", typeof(BGTZ)},
                {"010111", typeof(BGTZL)},
                {"000110", typeof(BLEZ)},
                {"010110", typeof(BLEZL)},
                {"000101", typeof(BNE)},
                {"010101", typeof(BNEL)},
                {"011000", typeof(DADDI)},
                {"011001", typeof(DADDIU)},
                {"000010", typeof(J)},
                {"000011", typeof(JAL)},
                {"100000", typeof(LB)},
                {"100100", typeof(LBU)},
                {"110111", typeof(LD)},
                {"011010", typeof(LDL)},
                {"011011", typeof(LDR)},
                {"100001", typeof(LH)},
                {"100101", typeof(LHU)},
                {"001111", typeof(LUI)},
                {"100011", typeof(LW)},
                {"100010", typeof(LWL)},
                {"100110", typeof(LWR)},
                {"100111", typeof(LWU)},
                {"001101", typeof(ORI)},
                {"110011", typeof(PREF)},
                {"101000", typeof(SB)},
                {"111111", typeof(SD)},
                {"101100", typeof(SDL)},
                {"101101", typeof(SDR)},
                {"101001", typeof(SH)},
                {"001010", typeof(SLTI)},
                {"001011", typeof(SLTIU)},
                {"101011", typeof(SW)},
                {"101010", typeof(SWL)},
                {"101110", typeof(SWR)},
                {"001110", typeof(XORI)},

                // C790 specific
                {"011110", typeof(LQ)},
                {"011111", typeof(SQ)},
            };

            _regimmCodes = new Dictionary<string, Type>()
            {
                {"00001", typeof(BGEZ)},
                {"10001", typeof(BGEZAL)},
                {"10011", typeof(BGEZALL)},
                {"00011", typeof(BGEZL)},
                {"00000", typeof(BLTZ)},
                {"10000", typeof(BLTZAL)},
                {"10010", typeof(BLTZALL)},
                {"00010", typeof(BLTZL)},
                {"01100", typeof(TEQI)},
                {"01000", typeof(TGEI)},
                {"01001", typeof(TGEIU)},
                {"01010", typeof(TLTI)},
                {"01011", typeof(TLTIU)},
                {"01110", typeof(TNEI)},
                {"11000", typeof(MTSAB)},
                {"11001", typeof(MTSAH)}
            };

            _specialCodes = new Dictionary<string, Type>()
            {
                {"100000", typeof(ADD)},
                {"100001", typeof(ADDU)},
                {"100100", typeof(AND)},
                {"001101", typeof(BREAK)},
                {"101100", typeof(DADD)},
                {"101101", typeof(DADDU)},
                {"011010", typeof(DIV)},
                {"011011", typeof(DIVU)},
                {"111000", typeof(DSLL)},
                {"111100", typeof(DSLL32)},
                {"010100", typeof(DSLLV)},
                {"111011", typeof(DSRA)},
                {"111111", typeof(DSRA32)},
                {"010111", typeof(DSRAV)},
                {"111010", typeof(DSRL)},
                {"111110", typeof(DSRL32)},
                {"010110", typeof(DSRLV)},
                {"101110", typeof(DSUB)},
                {"101111", typeof(DSUBU)},
                {"001001", typeof(JALR)},
                {"001000", typeof(JR)},
                {"010000", typeof(MFHI)},
                {"010010", typeof(MFLO)},
                {"001011", typeof(MOVN)},
                {"001010", typeof(MOVZ)},
                {"010001", typeof(MTHI)},
                {"010011", typeof(MTLO)},
                {"011000", typeof(MULT)},
                {"011001", typeof(MULTU)},
                {"100111", typeof(NOR)},
                {"100101", typeof(OR)},
                {"000000", typeof(SLL)},
                {"000100", typeof(SLLV)},
                {"101010", typeof(SLT)},
                {"101011", typeof(SLTU)},
                {"000011", typeof(SRA)},
                {"000111", typeof(SRAV)},
                {"000010", typeof(SRL)},
                {"000110", typeof(SRLV)},
                {"100010", typeof(SUB)},
                {"100011", typeof(SUBU)},
                {"001111", typeof(SYNC)},
                {"001100", typeof(SYSCALL)},
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
                {"011010", typeof(DIV1)},
                {"011011", typeof(DIVU1)},
                {"000000", typeof(MADD)},
                {"100000", typeof(MADD1)},
                {"000001", typeof(MADDU)},
                {"100001", typeof(MADDU1)},
                {"010000", typeof(MFHI1)},
                {"010010", typeof(MFLO1)},
                {"010001", typeof(MTHI1)},
                {"010011", typeof(MTLO1)},
                {"011000", typeof(MULT1)},
                {"011001", typeof(MULTU1)},
                {"000100", typeof(PLZCW)},
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
                
                {"01000", typeof(PADDB)},
                {"00100", typeof(PADDH)},
                {"11000", typeof(PADDSB)},
                {"10100", typeof(PADDSH)},
                {"10000", typeof(PADDSW)},
                {"00000", typeof(PADDW)},
                {"01010", typeof(PCGTB)},
                {"00110", typeof(PCGTH)},
                {"00010", typeof(PCGTW)},
                {"11110", typeof(PEXT5)},
                {"11010", typeof(PEXTLB)},
                {"10110", typeof(PEXTLH)},
                {"10010", typeof(PEXTLW)},
                {"00111", typeof(PMAXH)},
                {"00011", typeof(PMAXW)},
                {"11111", typeof(PPAC5)},
                {"11011", typeof(PPACB)},
                {"10111", typeof(PPACH)},
                {"10011", typeof(PPACW)},
                {"01001", typeof(PSUBB)},
                {"00101", typeof(PSUBH)},
                {"11001", typeof(PSUBSB)},
                {"10101", typeof(PSUBSH)},
                {"10001", typeof(PSUBSW)},
                {"00001", typeof(PSUBW)}
            };

            _mmi1Codes = new Dictionary<string, Type>()
            {
                {"00010", typeof(PCEQW)},
                {"00110", typeof(PCEQH)},
                {"01010", typeof(PCEQB)},
                {"00100", typeof(PADSBH)},
                {"10000", typeof(PADDUW)},
                {"10100", typeof(PADDUH)},
                {"11000", typeof(PADDUB)},
                {"00101", typeof(PABSH)},
                {"00001", typeof(PABSW)},
                {"11010", typeof(PEXTUB)},
                {"10110", typeof(PEXTUH)},
                {"10010", typeof(PEXTUW)},
                {"00111", typeof(PMINH)},
                {"00011", typeof(PMINW)},
                {"11001", typeof(PSUBUB)},
                {"10101", typeof(PSUBUH)},
                {"10001", typeof(PSUBUW)},
                {"11011", typeof(QFSRV)}
            };

            _mmi2Codes = new Dictionary<string, Type>()
            {
                {"11110", typeof(PEXEW)},
                {"11010", typeof(PEXEH)},
                {"01101", typeof(PDIVW)},
                {"11101", typeof(PDIVBW)},
                {"01110", typeof(PCPYLD)},
                {"10010", typeof(PAND)},
                {"10001", typeof(PHMADH)},
                {"10101", typeof(PHMSBH)},
                {"01010", typeof(PINTH)},
                {"10000", typeof(PMADDH)},
                {"00000", typeof(PMADDW)},
                {"01000", typeof(PMFHI)},
                {"01001", typeof(PMFLO)},
                {"10100", typeof(PMSUBH)},
                {"00100", typeof(PMSUBW)},
                {"11100", typeof(PMULTH)},
                {"01100", typeof(PMULTW)},
                {"11011", typeof(PREVH)},
                {"11111", typeof(PROT3W)},
                {"00010", typeof(PSLLVW)},
                {"00011", typeof(PSRLVW)},
                {"10011", typeof(PXOR)}
            };

            _mmi3Codes = new Dictionary<string, Type>()
            {
                {"11110", typeof(PEXCW)},
                {"11010", typeof(PEXCH)},
                {"01101", typeof(PDIVUW)},
                {"01110", typeof(PCPYUD)},
                {"11011", typeof(PCPYH)},
                {"01010", typeof(PINTEH)},
                {"00000", typeof(PMADDUW)},
                {"01000", typeof(PMTHI)},
                {"01001", typeof(PMTLO)},
                {"01100", typeof(PMULTUW)},
                {"10011", typeof(PNOR)},
                {"10010", typeof(POR)},
                {"00011", typeof(PSRAVW)}
            };
        }
    }
}
