namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LDR : ImmediateBase
    {
        public LDR()
        {
            OP = "LDR";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
