namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LB : ImmediateBase
    {
        public LB()
        {
            OP = "LB";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
