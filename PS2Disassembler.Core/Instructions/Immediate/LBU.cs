namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LBU : ImmediateBase
    {
        public LBU(string rs, string rt, short imm) : base("LBU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
