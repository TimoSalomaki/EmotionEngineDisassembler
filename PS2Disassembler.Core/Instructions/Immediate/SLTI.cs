namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTI : ImmediateBase
    {
        public SLTI(string rs, string rt, short imm) : base("SLTI", rs, rt, imm)
        {
        }
    }
}
