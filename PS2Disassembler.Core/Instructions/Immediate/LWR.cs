namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWR : ImmediateBase
    {
        public LWR(uint rs, uint rt, uint imm) : base("LWR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
