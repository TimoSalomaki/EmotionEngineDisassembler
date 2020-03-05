namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LDR : ImmediateBase
    {
        public LDR(uint rs, uint rt, uint imm) : base("LDR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
