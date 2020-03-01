namespace PS2Disassembler.Core.Instructions
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public short Imm { get; set; }

        protected ImmediateBase(string op, string rs, string rt, short imm) : base(op)
        {
            RS = rs;
            RT = rt;
            Imm = imm;
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
