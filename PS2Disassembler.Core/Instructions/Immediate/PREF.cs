namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class PREF : ImmediateBase
    {
        public PREF()
        {
            OP = "PREF";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // RT = Hint, Imm = Offset, RS = Base
        }
    }
}
