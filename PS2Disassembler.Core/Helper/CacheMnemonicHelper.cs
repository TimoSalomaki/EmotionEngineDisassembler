using System.Collections.Generic;

namespace PS2Disassembler.Core.Helper
{
    public class CacheMnemonicHelper
    {
        private readonly Dictionary<uint, string> _cacheInstructions;

        public CacheMnemonicHelper()
        {
            _cacheInstructions = new Dictionary<uint, string>()
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

        public string GetMnemonic(uint opCode)
        {
            return _cacheInstructions[opCode];
        }
    }
}
