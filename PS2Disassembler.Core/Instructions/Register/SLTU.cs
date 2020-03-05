namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLTU : RegisterBase
    {
        public SLTU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SLTU", rs, rt, rd, sa, funct)
        {
        }
    }
}
