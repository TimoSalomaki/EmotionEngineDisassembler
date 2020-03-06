namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTW : RegisterBase
    {
        public PMULTW(uint rs, uint rt, uint rd, uint sa) 
            : base("PMULTW", rs, rt, rd, sa)
        {
        }
    }
}
