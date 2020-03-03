namespace PS2Disassembler.Core.Instructions
{
    public abstract class BranchBase : ImmediateBase
    {
        protected BranchBase(string op, int rs, int rt, int offset) : base(op, rs, rt, offset)
        {

        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}"; // Imm = Offset
        }
    }
}
