namespace PS2Disassembler.Core.Instructions.Immediate.FPU
{
    public class SDC1 : ImmediateBase
    {
        public SDC1(int rs, int rt, int imm) : base("SDC1", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base, RT = FT
        }
    }
}
