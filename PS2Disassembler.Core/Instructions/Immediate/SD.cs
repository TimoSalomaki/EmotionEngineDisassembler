namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SD : ImmediateBase
    {
        public SD(int rs, int rt, int imm) : base("SD", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
