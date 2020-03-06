namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLT : RegisterBase
    {
        public SLT(uint rs, uint rt, uint rd, uint sa)
            : base("SLT", rs, rt, rd, sa)
        {
        }
    }
}
