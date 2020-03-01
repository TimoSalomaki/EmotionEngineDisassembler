namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SD : ImmediateBase
    {
        public SD()
        {
            OP = "SD";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
