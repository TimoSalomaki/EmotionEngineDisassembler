namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWL : ImmediateBase
    {
        public LWL(uint rs, uint rt, uint imm) : base("LWL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
