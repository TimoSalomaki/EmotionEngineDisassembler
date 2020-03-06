namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXW : RegisterBase
    {
        public PMAXW(uint rs, uint rt, uint rd, uint sa) 
            : base("PMAXW", rs, rt, rd, sa)
        {
        }
    }
}
