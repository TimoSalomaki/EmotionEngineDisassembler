namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVN : RegisterBase
    {
        public MOVN(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MOVN", rs, rt, rd, sa, funct)
        {
        }
    }
}
