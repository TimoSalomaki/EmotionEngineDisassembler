namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class DADDI : ImmediateBase
    {
        public DADDI(uint rs, uint rt, uint imm) : base("DADDI", rs, rt, imm)
        {
        }
    }
}
