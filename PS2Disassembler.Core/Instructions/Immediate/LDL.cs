namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LDL : ImmediateBase
    {
        public LDL(uint rs, uint rt, uint imm) : base("LDL", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
