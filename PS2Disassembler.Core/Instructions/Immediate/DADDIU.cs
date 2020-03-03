namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDIU : ImmediateBase
    {
        public DADDIU(int rs, int rt, int imm) : base("DADDIU", rs, rt, imm)
        {
        }
    }
}
