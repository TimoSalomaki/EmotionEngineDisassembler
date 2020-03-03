namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWR : ImmediateBase
    {
        public SWR(int rs, int rt, int imm) : base("SWR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
