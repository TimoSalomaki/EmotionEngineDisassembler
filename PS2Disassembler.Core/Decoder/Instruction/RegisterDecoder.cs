using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Register;
using PS2Disassembler.Core.Instructions.Register.C790;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class RegisterDecoder : InstructionDecoderBase
    {
        private readonly Dictionary<uint, Type> OpCodes;

        public RegisterDecoder()
        {
            OpCodes = new Dictionary<uint, Type>()
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
                {24, typeof(Instructions.Register.C790.MULT)},
                {25, typeof(Instructions.Register.C790.MULTU)}
            };
        }

        public object Decode(uint bits)
        {
            var funct = bits & 0x3F;
            var classType = OpCodes[funct];

            if (classType == typeof(Instructions.Register.C790.MULT))
            {
                if (((bits >> 6) & 0x1F) == 0)
                {
                    classType = typeof(Instructions.Register.MULT);
                }
            }

            else if (classType == typeof(Instructions.Register.C790.MULTU))
            {
                if (((bits >> 6) & 0x1F) == 0)
                {
                    classType = typeof(Instructions.Register.MULTU);
                }
            }

            var args = new object[]
            {
                (bits >> 21) & 0x1F,
                (bits >> 16) & 0x1F,
                (bits >> 11) & 0x1F,
                (bits >> 6) & 0x1F
            };

            return GetInstance(classType, args);
        }
    }
}
