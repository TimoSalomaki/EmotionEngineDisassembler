namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWL : ImmediateBase
    {
        public LWL(string rs, string rt, short imm) : base("LWL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
