namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEI : ImmediateBase
    {
        public TGEI(uint rs, uint rt, uint imm) : base("TGEI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
