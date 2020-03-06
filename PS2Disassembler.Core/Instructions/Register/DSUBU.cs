namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUBU : RegisterBase
    {
        public DSUBU(uint rs, uint rt, uint rd, uint sa)
            : base("DSUBU", rs, rt, rd, sa)
        {
        }
    }
}
