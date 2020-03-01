namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDI : ImmediateBase
    {
        public ADDI(string rs, string rt, short imm) : base("ADDI", rs, rt, imm)
        {
        }
    }
}
