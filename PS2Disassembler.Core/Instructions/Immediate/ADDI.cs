namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ADDI : ImmediateBase
    {
        public ADDI(int rs, int rt, int imm) : base("ADDI", rs, rt, imm)
        {
        }
    }
}
