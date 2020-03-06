namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBW : RegisterBase
    {
        public PSUBW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSUBW", rs, rt, rd, sa)
        {
        }
    }
}
