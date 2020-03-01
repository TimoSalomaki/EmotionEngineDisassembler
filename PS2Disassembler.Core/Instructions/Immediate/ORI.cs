namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ORI : ImmediateBase
    {
        public ORI(string rs, string rt, short imm) : base("ORI", rs, rt, imm)
        {
        }
    }
}
