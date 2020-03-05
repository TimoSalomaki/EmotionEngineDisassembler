namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADDU : RegisterBase
    {
        public ADDU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("ADDU", rs, rt, rd, sa, funct)
        {
        }
    }
}
