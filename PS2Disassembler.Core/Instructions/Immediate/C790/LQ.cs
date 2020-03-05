namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class LQ : ImmediateBase
    {
        public LQ(uint rs, uint rt, uint imm) : base("LQ", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
