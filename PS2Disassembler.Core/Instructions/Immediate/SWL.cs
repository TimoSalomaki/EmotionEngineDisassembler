namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWL : ImmediateBase
    {
        public SWL()
        {
            OP = "SWL";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
