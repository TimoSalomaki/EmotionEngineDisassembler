namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTI : ImmediateBase
    {
        public TLTI(uint rs, uint rt, uint imm) : base("TLTI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
