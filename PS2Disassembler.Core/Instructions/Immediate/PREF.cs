namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class PREF : ImmediateBase
    {
        public PREF(int rs, int rt, int imm) : base("PREF", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // RT = Hint, Imm = Offset, RS = Base
        }
    }
}
