namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDIU : ImmediateBase
    {
        public DADDIU(uint rs, uint rt, uint imm) : base("DADDIU", rs, rt, imm)
        {
        }
    }
}
