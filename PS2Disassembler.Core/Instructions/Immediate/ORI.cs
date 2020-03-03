namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class ORI : ImmediateBase
    {
        public ORI(int rs, int rt, int imm) : base("ORI", rs, rt, imm)
        {
        }
    }
}
