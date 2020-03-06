using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Immediate;
using PS2Disassembler.Core.Instructions.Immediate.Branch;
using PS2Disassembler.Core.Instructions.Immediate.C790;
using PS2Disassembler.Core.Instructions.Immediate.FPU;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class ImmediateDecoder : InstructionDecoderBase
    {
        private static readonly Dictionary<uint, Type> OpCodes;

        static ImmediateDecoder()
        {
            OpCodes = new Dictionary<uint, Type>()
            {
                {8, typeof(ADDI)},
                {9, typeof(ADDIU)},
                {12, typeof(ANDI)},
                {4, typeof(BEQ)},
                {20, typeof(BEQL)},
                {7, typeof(BGTZ)},
                {23, typeof(BGTZL)},
                {6, typeof(BLEZ)},
                {22, typeof(BLEZL)},
                {5, typeof(BNE)},
                {21, typeof(BNEL)},
                {24, typeof(DADDI)},
                {25, typeof(DADDIU)},
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

                // COP1 (FPU) specific
                {53, typeof(LDC1)},
                {49, typeof(LWC1)},
                {61, typeof(SDC1)},
                {57, typeof(SWC1)}
            };
        }

        public static object Decode(uint opCode, uint bits)
        {
            var classType = OpCodes[opCode];
            var args = new object[]
            {
                (bits >> 21) & 0x1F,
                (bits >> 16) & 0x1F,
                bits & 0xFFFF,
            };

            return GetInstance(classType, args);
        }
    }
}
