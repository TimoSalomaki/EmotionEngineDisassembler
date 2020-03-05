namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class SQ : ImmediateBase
    {
        public SQ(uint rs, uint rt, uint imm) : base("SQ", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
