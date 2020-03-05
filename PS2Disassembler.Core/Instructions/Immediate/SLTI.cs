namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTI : ImmediateBase
    {
        public SLTI(uint rs, uint rt, uint imm) : base("SLTI", rs, rt, imm)
        {
        }
    }
}
