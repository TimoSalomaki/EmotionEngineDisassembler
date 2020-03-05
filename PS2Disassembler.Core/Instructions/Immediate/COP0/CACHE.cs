namespace PS2Disassembler.Core.Instructions.Immediate.COP0
{
    public class CACHE : CacheBase
    {
        public CACHE(uint baseAddr, string mnemonic, uint offset) : base("CACHE", baseAddr, mnemonic, offset)
        {
        }
    }
}
