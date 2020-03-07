using System.Collections.Generic;
using PS2Disassembler.Core.Instructions.Immediate.COP0;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class CACHEDecoder : InstructionDecoderBase
    {
        private readonly Dictionary<uint, string> CacheInstructions;

        public CACHEDecoder()
        {
            CacheInstructions = new Dictionary<uint, string>()
            {
                {7, "IXIN"},
                {0, "IXLTG"},
                {4, "IXSTG"},
                {11, "IHIN"},
                {13, "IFL"},
                {1, "IXLDT"},
                {5, "IXSDT"},
                {2, "BXLBT"},
                {6, "BXSBT"},
                {12, "BFH"},
                {10, "BHINBT"},
                {20, "DXWBIN"},
                {16, "DXLTG"},
                {18, "DXSTG"},
                {22, "DXIN"},
                {26, "DHIN"},
                {24, "DHWBIN"},
                {17, "DXLDT"},
                {19, "DXSDT"},
                {28, "DHWOIN"},
            };
        }

        public object Decode(uint bits)
        {
            var classType = typeof(CACHE);

            var cacheOpCode = (bits >> 16) & 0x1F;
            var cacheMnemonic = CacheInstructions[cacheOpCode];

            var args = new object[]
            {
                (bits >> 21) & 0x1F, // BASE
                cacheMnemonic, // OP
                bits & 0xFFFF // OFFSET
            };

            return GetInstance(classType, args);
        }
    }
}