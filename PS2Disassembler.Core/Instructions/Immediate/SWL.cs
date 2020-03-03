namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWL : ImmediateBase
    {
        public SWL(int rs, int rt, int imm) : base("SWL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
