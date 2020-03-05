namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDI : ImmediateBase
    {
        public ADDI(uint rs, uint rt, uint imm) : base("ADDI", rs, rt, imm)
        {
        }
    }
}
