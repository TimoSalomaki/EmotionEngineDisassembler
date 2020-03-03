namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWR : ImmediateBase
    {
        public LWR(int rs, int rt, int imm) : base("LWR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
