namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLW : RegisterBase
    {
        public PEXTLW(uint rs, uint rt, uint rd, uint sa) 
            : base("PEXTLW", rs, rt, rd, sa)
        {
        }
    }
}
