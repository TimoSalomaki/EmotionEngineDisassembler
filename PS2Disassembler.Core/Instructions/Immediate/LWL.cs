namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWL : ImmediateBase
    {
        public LWL()
        {
            OP = "LWL";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
