namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ANDI : ImmediateBase
    {
        public ANDI(string rs, string rt, short imm) : base("ANDI", rs, rt, imm)
        {
        }
    }
}
