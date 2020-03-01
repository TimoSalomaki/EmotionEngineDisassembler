namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SB : ImmediateBase
    {
        public SB()
        {
            OP = "SB";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
