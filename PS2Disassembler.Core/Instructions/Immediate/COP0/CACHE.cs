namespace PS2Disassembler.Core.Instructions.Immediate.COP0
{
    public class CACHE : CacheBase
    {
        public CACHE(int baseAddr, string mnemonic, int offset) : base("CACHE", baseAddr, mnemonic, offset)
        {
        }
    }
}
