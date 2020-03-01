namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SB : ImmediateBase
    {
        public SB(string rs, string rt, short imm) : base("SB", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
