namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LHU : ImmediateBase
    {
        public LHU(int rs, int rt, int imm) : base("LHU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
