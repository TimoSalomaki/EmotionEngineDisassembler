namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SH : ImmediateBase
    {
        public SH(uint rs, uint rt, uint imm) : base("SH", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
