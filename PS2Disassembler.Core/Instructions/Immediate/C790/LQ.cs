namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class LQ : ImmediateBase
    {
        public LQ(int rs, int rt, int imm) : base("LQ", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
