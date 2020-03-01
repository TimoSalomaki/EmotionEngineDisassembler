namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDIU : ImmediateBase
    {
        public ADDIU(string rs, string rt, short imm) : base("ADDIU", rs, rt, imm)
        {
        }
    }
}
