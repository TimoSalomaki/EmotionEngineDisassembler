namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LW : ImmediateBase
    {
        public LW()
        {
            OP = "LW";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
