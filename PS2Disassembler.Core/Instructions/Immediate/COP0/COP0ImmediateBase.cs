namespace PS2Disassembler.Core.Instructions.Immediate.COP0
{
    public abstract class COP0ImmediateBase : InstructionBase
    {
        protected COP0ImmediateBase(string op, uint offset) : base(op)
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
