namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUBU : RegisterBase
    {
        public DSUBU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
