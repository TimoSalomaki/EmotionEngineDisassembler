namespace PS2Disassembler.Core.Instructions
{
    public abstract class CacheBase : InstructionBase
    {
        protected CacheBase(string op, int baseAddr, string mnemonic, int offset) : base(op)
        {
            BaseAddr = "0x" + baseAddr.ToString("X");
            Mnemonic = mnemonic;
            BaseAddr = "0x" + offset.ToString("X");
        }

        public string BaseAddr { get; set; }
        public string Mnemonic { get; set; }
        public string Offset { get; set; }

        public override string ToString()
        {
            return $"{OP} {Mnemonic}, {Offset} ({BaseAddr})";
        }
    }
}
