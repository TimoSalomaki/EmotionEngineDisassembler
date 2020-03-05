namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDIU : ImmediateBase
    {
        public ADDIU(uint rs, uint rt, uint imm) : base("ADDIU", rs, rt, imm)
        {
        }
    }
}
