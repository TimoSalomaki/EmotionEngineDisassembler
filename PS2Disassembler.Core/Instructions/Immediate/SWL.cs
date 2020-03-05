namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWL : ImmediateBase
    {
        public SWL(uint rs, uint rt, uint imm) : base("SWL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
