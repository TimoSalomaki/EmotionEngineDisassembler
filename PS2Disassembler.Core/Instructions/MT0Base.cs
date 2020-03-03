namespace PS2Disassembler.Core.Instructions
{
    public abstract class MT0Base : InstructionBase
    {
        protected MT0Base(string op, int rt, int rd)
            : base(op)
        {
            RT = "0x" + rt.ToString("X");
            RD = "0x" + rd.ToString("X");
        }

        public string RT { get; set; }
        public string RD { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}, {RD}";
        }
    }
}
