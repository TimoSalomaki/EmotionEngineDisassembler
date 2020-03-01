namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWU : ImmediateBase
    {
        public LWU()
        {
            OP = "LWU";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
