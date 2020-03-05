namespace PS2Disassembler.Core.Instructions.Immediate.FPU
{
    public class LDC1 : ImmediateBase
    {
        public LDC1(uint rs, uint rt, uint imm) : base("LDC1", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base, RT = FT
        }
    }
}
