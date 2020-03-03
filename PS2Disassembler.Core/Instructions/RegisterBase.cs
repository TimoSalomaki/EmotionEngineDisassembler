namespace PS2Disassembler.Core.Instructions
{
    public abstract class RegisterBase : InstructionBase
    {
        protected RegisterBase(string op, int rs, int rt, int rd, int sa, int funct)
            : base(op)
        {
            RS = "0x" + rs.ToString("X");
            RT = "0x" + rt.ToString("X");
            RD = "0x" + rd.ToString("X");
            SA = "0x" + sa.ToString("X");
            Funct = "0x" + funct.ToString("X"); // Probably not needed
        }

        public string RS { get; set; }
        public string RT { get; set; }
        public string RD { get; set; }
        public string SA { get; set; }
        public string Funct { get; set; }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}, {RT}";
        }
    }
}
