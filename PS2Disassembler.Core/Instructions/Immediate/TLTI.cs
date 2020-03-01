namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTI : ImmediateBase
    {
        public TLTI(string rs, string rt, short imm) : base("TLTI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
