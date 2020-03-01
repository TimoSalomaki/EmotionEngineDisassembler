namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SD : ImmediateBase
    {
        public SD(string rs, string rt, short imm) : base("SD", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
