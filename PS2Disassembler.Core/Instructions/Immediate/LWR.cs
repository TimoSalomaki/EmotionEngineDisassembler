namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LWR : ImmediateBase
    {
        public LWR()
        {
            OP = "LWR";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
