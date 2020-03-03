namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDI : ImmediateBase
    {
        public DADDI(int rs, int rt, int imm) : base("DADDI", rs, rt, imm)
        {
        }
    }
}
