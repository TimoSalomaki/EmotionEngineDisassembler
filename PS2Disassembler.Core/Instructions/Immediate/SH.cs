namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SH : ImmediateBase
    {
        public SH(string rs, string rt, short imm) : base("SH", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
