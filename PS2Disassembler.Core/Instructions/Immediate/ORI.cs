namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ORI : ImmediateBase
    {
        public ORI(uint rs, uint rt, uint imm) : base("ORI", rs, rt, imm)
        {
        }
    }
}
