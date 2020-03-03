namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TNEI : ImmediateBase
    {
        public TNEI(int rs, int rt, int imm) : base("TNEI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
