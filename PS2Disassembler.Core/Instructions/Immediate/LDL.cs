namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LDL : ImmediateBase
    {
        public LDL()
        {
            OP = "LDL";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
