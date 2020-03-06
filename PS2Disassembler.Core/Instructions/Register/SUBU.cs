namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUBU : RegisterBase
    {
        public SUBU(uint rs, uint rt, uint rd, uint sa)
            : base("SUBU", rs, rt, rd, sa)
        {
        }
    }
}
