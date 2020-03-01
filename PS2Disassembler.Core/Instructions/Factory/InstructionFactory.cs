using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PS2Disassembler.Core.Instructions.Factory
{
    public class InstructionFactory : IInstructionFactory
    {
        private const string SPECIAL = "000000";
        private const string REGIMM = "000001";
        private Dictionary<string, InstructionType> _instructionTypes;
        private Dictionary<string, string> _instructionOpCodes;
        private Dictionary<string, string> _branchCodes;
        private Dictionary<string, string> _trapCodes;
        private Dictionary<string, string> _specialCodes;

        public InstructionFactory()
        {
            InitializeDictionaries();
        }

        public InstructionBase CreateInstruction(int input)
        {
            if (input == 0)
                return new Nop();

            string binary = Convert.ToString(input, 2);
            string opBin = binary.Substring(0, 6);
            var newInstruction = default(InstructionBase);

            try
            {
                switch (_instructionTypes[opBin])
                {
                    case InstructionType.Immediate:
                        newInstruction = new ImmediateBase()
                        {
                            OP = _instructionOpCodes[opBin],
                            Type = InstructionType.Immediate
                        };
                        break;

                    case InstructionType.Jump:
                        newInstruction = new ImmediateBase()
                        {
                            OP = _instructionOpCodes[opBin],
                            Type = InstructionType.Jump
                        };
                        break;

                    case InstructionType.Register:
                        newInstruction = new ImmediateBase()
                        {
                            OP = _specialCodes[opBin],
                            Type = InstructionType.Register
                        };
                        break;

                    case InstructionType.Regimm:
                        newInstruction = new ImmediateBase()
                        {
                            OP = _regimmRTCodes[opBin],
                            Type = InstructionType.Regimm
                        };
                        break;
                }
            }

            catch (KeyNotFoundException)
            {
                return new Nop();
            }

            return newInstruction;
        }

        private void InitializeDictionaries()
        {
            _instructionTypes = new Dictionary<string, InstructionType>()
            {
                {"000000", InstructionType.Register},  // SPECIAL
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
                {"000010", InstructionType.Jump},      // J
                {"000011", InstructionType.Jump},      // JAL
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
                {"001110", InstructionType.Immediate} // XORI
            };

            _instructionOpCodes = new Dictionary<string, string>()
            {
                {"000000", "SPECIAL"},
                {"001000", "ADDI"},
                {"001001", "ADDIU"},
                {"001100", "ANDI"},
                {"000100", "BEQ"},
                {"010100", "BEQL"},
                {"000001", "REGIMM"},
                {"000111", "BGTZ"},
                {"010111", "BGTZL"},
                {"000110", "BLEZ"},
                {"010110", "BLEZL"},
                {"000101", "BNE"},
                {"010101", "BNEL"},
                {"011000", "DADDI"},
                {"011001", "DADDIU"},
                {"000010", "J"},
                {"000011", "JAL"},
                {"100000", "LB"},
                {"100100", "LBU"},
                {"110111", "LD"},
                {"011010", "LDL"},
                {"011011", "LDR"},
                {"100001", "LH"},
                {"100101", "LHU"},
                {"001111", "LUI"},
                {"100011", "LW"},
                {"100010", "LWL"},
                {"100110", "LWR"},
                {"100111", "LWU"},
                {"001101", "ORI"},
                {"110011", "PREF"},
                {"101000", "SB"},
                {"111111", "SD"},
                {"101100", "SDL"},
                {"101101", "SDR"},
                {"101001", "SH"},
                {"001010", "SLTI"},
                {"001011", "SLTIU"},
                {"101011", "SW"},
                {"101010", "SWL"},
                {"101110", "SWR"},
                {"001110", "XORI"}
            };

            _branchCodes = new Dictionary<string, string>()
            {
                {"00001", "BGEZ"},
                {"10001", "BGEZAL"},
                {"10011", "BGEZALL"},
                {"00011", "BGEZL"},
                {"00000", "BLTZ"},
                {"10000", "BLTZAL"},
                {"10010", "BLTZALL"},
                {"00010", "BLTZL"}
            };

            _trapCodes = new Dictionary<string, string>()
            {
                {"01100", "TEQI"},
                {"01000", "TGEI"},
                {"01001", "TGEIU"},
                {"01010", "TLTI"},
                {"01011", "TLTIU"},
                {"01110", "TNEI"}
            };

                _specialCodes = new Dictionary<string, string>()
            {
                {"100000", "ADD"},
                {"100001", "ADDU"},
                {"100100", "AND"},
                {"001101", "BREAK"},
                {"101100", "DADD"},
                {"101101", "DADDU"},
                {"011010", "DIV"},
                {"011011", "DIVU"},
                {"111000", "DSLL"},
                {"111100", "DSLL32"},
                {"010100", "DSLLV"},
                {"111011", "DSRA"},
                {"111111", "DSRA32"},
                {"010111", "DSRAV"},
                {"111010", "DSRL"},
                {"111110", "DSRL32"},
                {"010110", "DSRLV"},
                {"101110", "DSUB"},
                {"101111", "DSUBU"},
                {"001001", "JALR"},
                {"001000", "JR"},
                {"010000", "MFHI"},
                {"010010", "MFLO"},
                {"001011", "MOVN"},
                {"001010", "MOVZ"},
                {"010001", "MTHI"},
                {"010011", "MTLO"},
                {"011000", "MULT"},
                {"011001", "MULTU"},
                {"100111", "NOR"},
                {"100101", "OR"},
                {"000000", "SLL"},
                {"000100", "SLLV"},
                {"101010", "SLT"},
                {"101011", "SLTU"},
                {"000011", "SRA"},
                {"000111", "SRAV"},
                {"000010", "SRL"},
                {"000110", "SRLV"},
                {"100010", "SUB"},
                {"100011", "SUBU"},
                {"001111", "SYNC"},
                {"001100", "SYSCALL"},
                {"110100", "TEQ"},
                {"110000", "TGE"},
                {"110001", "TGEU"},
                {"110010", "TLT"},
                {"110011", "TLTU"},
                {"110110", "TNE"},
                {"100110", "XOR"}
            };
        }
    }
}
