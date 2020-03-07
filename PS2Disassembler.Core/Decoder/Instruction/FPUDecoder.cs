using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Immediate.FPU;
using PS2Disassembler.Core.Instructions.Register.FPU;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class FPUDecoder : InstructionDecoderBase
    {
        private readonly Dictionary<uint, Type> RSOpCodes;
        private readonly Dictionary<uint, Type> FuncOpCodes;
        private readonly Dictionary<uint, string> CCondMnemonics;

        public FPUDecoder()
        {
            RSOpCodes = new Dictionary<uint, Type>()
            {
                {2, typeof(CFC1)},
                {6, typeof(CTC1)},
                {1, typeof(DMFC1)},
                {5, typeof(DMTC1)},
                {0, typeof(MFC1)},
                {4, typeof(MTC1)}
            };

            FuncOpCodes = new Dictionary<uint, Type>()
            {
                {5, typeof(ABSfmt)},
                {10, typeof(CEILLfmt)},
                {14, typeof(CEILWfmt)},
                {33, typeof(CVTDfmt)},
                {37, typeof(CVTSfmt)},
                {32, typeof(CVTLfmt)},
                {36, typeof(CVTWfmt)},
                {11, typeof(FLOORLfmt)},
                {15, typeof(FLOORWfmt)},
                {6, typeof(MOVfmt)},
                {7, typeof(NEGfmt)},
                {8, typeof(ROUNDLfmt)},
                {12, typeof(ROUNDWfmt)},
                {4, typeof(SQRTfmt)},
                {9, typeof(TRUNCLfmt)},
                {13, typeof(TRUNCWfmt)},
                {0, typeof(ADDfmt)},
                {3, typeof(DIVfmt)},
                {2, typeof(MULfmt)},
                {1, typeof(SUBfmt)}
            };

            CCondMnemonics = new Dictionary<uint, string>()
            {
                {48, "F"},
                {49, "UN"},
                {50, "EQ"},
                {51, "UEQ"},
                {52, "OLT"},
                {53, "ULT"},
                {54, "OLE"},
                {55, "ULE"},
                {56, "SF"},
                {57, "NGLE"},
                {58, "SEQ"},
                {59, "NGL"},
                {60, "LT"},
                {61, "NGE"},
                {62, "LE"},
                {63, "NGT"}
            };
        }

        public object Decode(uint bits)
        {
            var rs = (bits >> 21) & 0x1F;
            var rt = (bits >> 16) & 0x1F;
            var fs = (bits >> 11) & 0x1F;
            var fd = (bits >> 6) & 0x1F;
            var function = bits & 0x3F;

            Type classType = default;

            var args = new object[]
            {
                rs,
                rt,
                fs,
                fd
            };

            if (rs <= 6)
            {
                classType = RSOpCodes[rs];
            }

            else if (rs == 8) // BC1
            {
                classType = rt == 0 ? typeof(BC1F) : typeof(BC1T);

                args = new object[]
                {
                    bits & 0xFFFF
                };
            }

            else if (rs == 16 || rs == 17)
            {
                if (function <= 37)
                    classType = FuncOpCodes[function];

                else // C.cond.fmt
                {
                    classType = typeof(Ccondfmt);

                    args = new object[]
                    {
                        rs,
                        rt,
                        fs,
                        fd,
                        CCondMnemonics[function]
                    };
                }
            }

            else if (rs == 20 || rs == 21)
            {
                if (function == 32)
                    classType = typeof(CVTSfmt);

                else if (function == 33)
                    classType = typeof(CVTDfmt);
            }

            return GetInstance(classType, args);
        }
    }
}