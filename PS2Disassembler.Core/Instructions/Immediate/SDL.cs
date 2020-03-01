namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SDL : ImmediateBase
    {
        public SDL(string rs, string rt, short imm) : base("SDL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
