namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class PREF : ImmediateBase
    {
        public PREF(string rs, string rt, short imm) : base("PREF", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // RT = Hint, Imm = Offset, RS = Base
        }
    }
}
