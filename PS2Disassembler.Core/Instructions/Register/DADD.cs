namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADD : RegisterBase
    {
        public DADD(uint rs, uint rt, uint rd, uint sa)
            : base("DADD", rs, rt, rd, sa)
        {
        }
    }
}
