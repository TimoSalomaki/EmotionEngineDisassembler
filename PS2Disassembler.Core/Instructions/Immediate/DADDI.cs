namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDI : ImmediateBase
    {
        public DADDI(string rs, string rt, short imm) : base("DADDI", rs, rt, imm)
        {
        }
    }
}
