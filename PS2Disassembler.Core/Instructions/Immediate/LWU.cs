namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWU : ImmediateBase
    {
        public LWU(string rs, string rt, short imm) : base("LWU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
