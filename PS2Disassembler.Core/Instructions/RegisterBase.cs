namespace PS2Disassembler.Core.Instructions
{
    public abstract class RegisterBase : InstructionBase
    {
        protected RegisterBase(string op, string rs, string rt, string rd, string sa, string funct)
            : base(op)
        {
            RS = rs;
            RT = rt;
            RD = rd;
            SA = sa;
            Funct = funct; // Probably not needed
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
