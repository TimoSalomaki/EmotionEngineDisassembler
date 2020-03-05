namespace PS2Disassembler.Core.Instructions.Immediate.FPU
{
    public class SWC1 : ImmediateBase
    {
        public SWC1(uint rs, uint rt, uint imm) : base("SWC1", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base, RT = FT
        }
    }
}
