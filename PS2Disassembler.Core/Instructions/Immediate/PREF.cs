namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class PREF : ImmediateBase
    {
        public PREF(uint rs, uint rt, uint imm) : base("PREF", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // RT = Hint, Imm = Offset, RS = Base
        }
    }
}
