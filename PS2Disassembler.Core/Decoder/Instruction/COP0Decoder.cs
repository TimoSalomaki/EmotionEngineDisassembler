using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Immediate.COP0;
using PS2Disassembler.Core.Instructions.Register.COP0;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class COP0Decoder : InstructionDecoderBase
    {
        private static readonly Dictionary<uint, Type> MFDebugOpCodes;
        private static readonly Dictionary<uint, Type> MTDebugOpCodes;
        private static readonly Dictionary<uint, Type> C0OpCodes;

        static COP0Decoder()
        {
            MFDebugOpCodes = new Dictionary<uint, Type>()
            {
                {0, typeof(MFBPC)},
                {4, typeof(MFDAB)},
                {5, typeof(MFDABM)},
                {6, typeof(MFDVB)},
                {7, typeof(MFDVBM)},
                {2, typeof(MFIAB)},
                {3, typeof(MFIABM)}
            };

            MTDebugOpCodes = new Dictionary<uint, Type>()
            {
                {0, typeof(MTBPC)},
                {4, typeof(MTDAB)},
                {5, typeof(MTDABM)},
                {6, typeof(MTDVB)},
                {7, typeof(MTDVBM)},
                {2, typeof(MTIAB)},
                {3, typeof(MTIABM)}
            };

            C0OpCodes = new Dictionary<uint, Type>()
            {
                {57, typeof(DI)},
                {56, typeof(EI)},
                {24, typeof(ERET)},
                {8, typeof(TLBP)},
                {1, typeof(TLBR)},
                {2, typeof(TLBWI)},
                {6, typeof(TLBWR)}
            };
        }

        public static object Decode(uint bits)
        {
            var typeNr = (bits >> 21) & 0x1F;
            Type classType = default;
            object[] args = default;

            switch (typeNr)
            {
                case 8: // BC0
                    switch ((bits >> 16) & 0x1F)
                    {
                        case 0:
                            classType = typeof(BC0F);
                            break;
                        case 1:
                            classType = typeof(BC0T);
                            break;
                        case 2:
                            classType = typeof(BC0FL);
                            break;
                        case 3:
                            classType = typeof(BC0TL);
                            break;
                    }

                    args = new object[]
                    {
                        bits & 0xFFFF
                    };
                    break;

                case 16: // C0
                    classType = C0OpCodes[bits & 0x3F];
                    break;

                case 0: // MF0
                case 4: // MT0
                    var rd = (bits >> 11) & 0x1F;
                    var rs = (bits >> 21) & 0x1F;
                    switch (rd)
                    {
                        case 24: // Debug
                            classType = rs == 0 ? MFDebugOpCodes[bits & 0x7] : MTDebugOpCodes[bits & 0x7];

                            args = new object[]
                            {
                                (bits >> 16) & 0x1F, // RT
                                (bits >> 11) & 0x1F // RD (= Debug 11000)
                            };
                            break;

                        case 25: // Perf
                            if (rs == 0)
                                classType = (bits & 0x1) == 0 ? typeof(MFPS) : typeof(MFPC);

                            else if (rs == 4)
                                classType = (bits & 0x1) == 0 ? typeof(MTPS) : typeof(MTPC);
                            args = new object[]
                            {
                                (bits >> 16) & 0x1F, // RT
                                (bits >> 1) & 0x1F // Reg
                            };
                            break;

                        default: //MFC0, MTC0
                            classType = rs == 0 ? typeof(MFC0) : typeof(MTC0);

                            args = new object[]
                            {
                                (bits >> 16) & 0x1F, // RT
                                (bits >> 11) & 0x1F // RD
                            };
                            break;
                    }

                    break;
            }


            return GetInstance(classType, args);
        }
    }
}