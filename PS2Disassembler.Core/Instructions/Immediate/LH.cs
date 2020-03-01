namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LH : ImmediateBase
    {
        public LH(string rs, string rt, short imm) : base("LH", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
