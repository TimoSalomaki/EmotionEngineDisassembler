namespace PS2Disassembler.Core.Instructions
{
    public abstract class BranchBase : ImmediateBase
    {
        protected BranchBase(string op, uint rs, uint rt, uint offset) : base(op, rs, rt, offset)
        {

        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}"; // Imm = Offset
        }
    }
}
