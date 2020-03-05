namespace PS2Disassembler.Core.Instructions.Register
{
    public class OR : RegisterBase
    {
        public OR(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("OR", rs, rt, rd, sa, funct)
        {
        }
    }
}
