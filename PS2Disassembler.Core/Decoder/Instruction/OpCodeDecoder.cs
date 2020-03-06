using System.Collections.Generic;
using PS2Disassembler.Core.Instructions;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class OpCodeDecoder
    {
        private static readonly Dictionary<uint, InstructionType> OpCodes;

        static OpCodeDecoder()
        {
            OpCodes = new Dictionary<uint, InstructionType>()
            {
                {0, InstructionType.Register}, // SPECIAL

                // BGEZ,BGEZAL,BGEZALL,BGEZL,BLTZ,BLTZAL,BLTZALL,BLTZL,TEQI,TGEI,TGEIU,TLTI,TLTIU,TNEI
                {1, InstructionType.Regimm},

                {2, InstructionType.Jump}, // J
                {3, InstructionType.Jump}, // JAL

                {8, InstructionType.Immediate}, // ADDI
                {9, InstructionType.Immediate}, // ADDIU
                {12, InstructionType.Immediate}, // ANDI
                {4, InstructionType.Immediate}, // BEQ
                {20, InstructionType.Immediate}, // BEQL
                {7, InstructionType.Immediate}, // BGTZ
                {23, InstructionType.Immediate}, // BGTZL
                {6, InstructionType.Immediate}, // BLEZ
                {22, InstructionType.Immediate}, // BLEZL
                {5, InstructionType.Immediate}, // BNE
                {21, InstructionType.Immediate}, // BNEL
                {24, InstructionType.Immediate}, // DADDI
                {25, InstructionType.Immediate}, // DADDIU
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
                {30, InstructionType.Immediate}, // LQ
                {31, InstructionType.Immediate}, // SQ
                {53, InstructionType.Immediate},
                {49, InstructionType.Immediate},
                {61, InstructionType.Immediate},
                {57, InstructionType.Immediate},

                {28, InstructionType.MMI}, // C790 specific

                {16, InstructionType.Cop0}, // System coprosessor

                {17, InstructionType.FPU}, // COP1  (FPU)
                {47, InstructionType.CACHE}, // COP1 (FPU)

                // Reserved instructions
                {18, InstructionType.Nop},
                {19, InstructionType.Nop},
                {29, InstructionType.Nop},
                {48, InstructionType.Nop},
                {50, InstructionType.Nop},
                {52, InstructionType.Nop},
                {54, InstructionType.Nop},
                {56, InstructionType.Nop},
                {58, InstructionType.Nop},
                {59, InstructionType.Nop},
                {60, InstructionType.Nop},
                {62, InstructionType.Nop}
            };
        }

        public static InstructionType GetInstructionType(uint opCode)
        {
            try
            {
                return OpCodes[opCode];
            }

            catch (KeyNotFoundException)
            {
                return InstructionType.Nop;
            }
        }
    }
}
