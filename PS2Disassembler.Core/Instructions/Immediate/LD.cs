namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LD : ImmediateBase
    {
        public LD()
        {
            OP = "LD";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
