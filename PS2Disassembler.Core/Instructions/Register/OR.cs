namespace PS2Disassembler.Core.Instructions.Register
{
    public class OR : RegisterBase
    {
        public OR(uint rs, uint rt, uint rd, uint sa)
            : base("OR", rs, rt, rd, sa)
        {
        }
    }
}
