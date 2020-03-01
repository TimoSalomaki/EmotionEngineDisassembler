namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWR : ImmediateBase
    {
        public LWR(string rs, string rt, short imm) : base("LWR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
