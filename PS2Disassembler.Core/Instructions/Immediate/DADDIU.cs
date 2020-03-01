namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDIU : ImmediateBase
    {
        public DADDIU(string rs, string rt, short imm) : base("DADDIU", rs, rt, imm)
        {
        }
    }
}
