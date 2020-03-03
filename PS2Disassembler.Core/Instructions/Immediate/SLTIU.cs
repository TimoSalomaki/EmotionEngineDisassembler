namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SLTIU : ImmediateBase
    {
        public SLTIU(int rs, int rt, int imm) : base("SLTIU", rs, rt, imm)
        {
        }
    }
}
