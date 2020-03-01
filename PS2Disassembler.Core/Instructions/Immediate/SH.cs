namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SH : ImmediateBase
    {
        public SH()
        {
            OP = "SH";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
