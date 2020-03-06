namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADDU : RegisterBase
    {
        public DADDU(uint rs, uint rt, uint rd, uint sa)
            : base("DADDU", rs, rt, rd, sa)
        {
        }
    }
}
