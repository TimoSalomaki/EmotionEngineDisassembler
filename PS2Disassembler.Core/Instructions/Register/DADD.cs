namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADD : RegisterBase
    {
        public DADD(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
