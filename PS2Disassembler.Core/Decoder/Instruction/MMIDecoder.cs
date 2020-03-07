using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Register.C790;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class MMIDecoder : InstructionDecoderBase
    {
        private readonly Dictionary<uint, Type> MmiCodes;
        private readonly Dictionary<uint, Type> Mmi0Codes;
        private readonly Dictionary<uint, Type> Mmi1Codes;
        private readonly Dictionary<uint, Type> Mmi2Codes;
        private readonly Dictionary<uint, Type> Mmi3Codes;

        public MMIDecoder()
        {
            MmiCodes = new Dictionary<uint, Type>()
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

            Mmi0Codes = new Dictionary<uint, Type>()
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

            Mmi1Codes = new Dictionary<uint, Type>()
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

            Mmi2Codes = new Dictionary<uint, Type>()
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

            Mmi3Codes = new Dictionary<uint, Type>()
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

        public object Decode(uint bits)
        {
            var mmiNr = bits & 0x3F;

            // For MMI0, MMI1, MMI2 and MMI3, the opcode is in the SA part of the instruction
            var opCode = (bits >> 6) & 0x1F;
            Type classType;

            switch (mmiNr)
            {
                case 8: // MMI0
                    classType = Mmi0Codes[opCode];
                    break;

                case 40: // MMI1
                    classType = Mmi1Codes[opCode];
                    break;

                case 9: // MMI2
                    classType = Mmi2Codes[opCode];
                    break;

                case 41: // MMI3
                    classType = Mmi3Codes[opCode];
                    break;

                default: // MMI
                    classType = MmiCodes[mmiNr];
                    break;
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
