namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDIU : ImmediateBase
    {
        public ADDIU(int rs, int rt, int imm) : base("ADDIU", rs, rt, imm)
        {
        }
    }
}
