namespace PS2Disassembler.Core.Instructions
{
    public abstract class FPUImmediateBase : InstructionBase
    {
        protected FPUImmediateBase(string op, uint offset) : base(op)
        {
            Offset = "0x" + offset.ToString("X");
        }

        public string Offset { get; set; }

        public override string ToString()
        {
            return $"{OP} {Offset}"; // Imm = offset
        }
    }
}
