namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEI : ImmediateBase
    {
        public TGEI(string rs, string rt, short imm) : base("TGEI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
