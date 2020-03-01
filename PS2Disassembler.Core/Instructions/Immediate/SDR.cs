namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SDR : ImmediateBase
    {
        public SDR()
        {
            OP = "SDR";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
