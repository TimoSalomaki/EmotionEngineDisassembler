namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SDL : ImmediateBase
    {
        public SDL()
        {
            OP = "SDL";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
