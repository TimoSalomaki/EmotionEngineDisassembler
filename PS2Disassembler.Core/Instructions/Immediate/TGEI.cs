namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEI : ImmediateBase
    {
        public TGEI(int rs, int rt, int imm) : base("TGEI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
