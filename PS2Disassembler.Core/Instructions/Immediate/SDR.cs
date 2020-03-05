namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SDR : ImmediateBase
    {
        public SDR(uint rs, uint rt, uint imm) : base("SDR", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
