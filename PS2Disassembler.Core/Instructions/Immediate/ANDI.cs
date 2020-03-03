namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ANDI : ImmediateBase
    {
        public ANDI(int rs, int rt, int imm) : base("ANDI", rs, rt, imm)
        {
        }
    }
}
