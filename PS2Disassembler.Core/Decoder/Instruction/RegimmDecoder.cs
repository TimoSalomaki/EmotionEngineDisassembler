using System;
using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Immediate;
using PS2Disassembler.Core.Instructions.Immediate.Branch;
using PS2Disassembler.Core.Instructions.Immediate.C790;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class RegimmDecoder : InstructionDecoderBase
    {
        private readonly Dictionary<uint, Type> OpCodes;

        public RegimmDecoder()
        {
            OpCodes = new Dictionary<uint, Type>()
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
        }

        public object Decode(uint bits)
        {
            var opCode = (bits >> 16) & 0x1F;

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
