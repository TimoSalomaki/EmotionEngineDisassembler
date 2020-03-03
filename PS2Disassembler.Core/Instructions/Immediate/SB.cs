namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SB : ImmediateBase
    {
        public SB(int rs, int rt, int imm) : base("SB", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
