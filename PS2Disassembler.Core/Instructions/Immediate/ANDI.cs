namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ANDI : ImmediateBase
    {
        public ANDI(uint rs, uint rt, uint imm) : base("ANDI", rs, rt, imm)
        {
        }
    }
}
