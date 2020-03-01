namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SWR : ImmediateBase
    {
        public SWR()
        {
            OP = "SWR";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
