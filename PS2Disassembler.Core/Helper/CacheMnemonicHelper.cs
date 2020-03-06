using System.Collections.Generic;

namespace PS2Disassembler.Core.Helper
{
    public class CacheMnemonicHelper
    {
        private static readonly Dictionary<uint, string> CacheInstructions;

        static CacheMnemonicHelper()
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

        public static string GetMnemonic(uint opCode)
        {
            return CacheInstructions[opCode];
        }
    }
}
