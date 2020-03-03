namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTI : ImmediateBase
    {
        public SLTI(int rs, int rt, int imm) : base("SLTI", rs, rt, imm)
        {
        }
    }
}
