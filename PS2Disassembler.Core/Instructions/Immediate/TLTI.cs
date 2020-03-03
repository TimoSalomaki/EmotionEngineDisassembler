namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTI : ImmediateBase
    {
        public TLTI(int rs, int rt, int imm) : base("TLTI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
