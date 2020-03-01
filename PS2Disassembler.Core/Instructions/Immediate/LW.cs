namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LW : ImmediateBase
    {
        public LW(string rs, string rt, short imm) : base("LW", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
