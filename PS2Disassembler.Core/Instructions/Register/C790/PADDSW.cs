namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSW : RegisterBase
    {
        public PADDSW(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDSW", rs, rt, rd, sa)
        {
        }
    }
}
