namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTIU : ImmediateBase
    {
        public SLTIU(string rs, string rt, short imm) : base("SLTIU", rs, rt, imm)
        {
        }
    }
}
