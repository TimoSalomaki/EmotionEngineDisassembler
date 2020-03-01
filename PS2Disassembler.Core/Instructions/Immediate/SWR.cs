namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWR : ImmediateBase
    {
        public SWR(string rs, string rt, short imm) : base("SWR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
