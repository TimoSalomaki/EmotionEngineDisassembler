namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTIU : ImmediateBase
    {
        public SLTIU(uint rs, uint rt, uint imm) : base("SLTIU", rs, rt, imm)
        {
        }
    }
}
