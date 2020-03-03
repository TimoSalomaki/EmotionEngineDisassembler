namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWL : ImmediateBase
    {
        public LWL(int rs, int rt, int imm) : base("LWL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
