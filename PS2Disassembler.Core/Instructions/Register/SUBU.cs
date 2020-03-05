namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUBU : RegisterBase
    {
        public SUBU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
