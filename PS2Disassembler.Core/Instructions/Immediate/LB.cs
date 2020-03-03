namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LB : ImmediateBase
    {
        public LB(int rs, int rt, int imm) : base("LB", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
