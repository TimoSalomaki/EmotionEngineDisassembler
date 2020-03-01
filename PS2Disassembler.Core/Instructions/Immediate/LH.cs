namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LH : ImmediateBase
    {
        public LH()
        {
            OP = "LH";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
