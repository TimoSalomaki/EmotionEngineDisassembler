namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LD : ImmediateBase
    {
        public LD(uint rs, uint rt, uint imm) : base("LD", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
