namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMSUBW : RegisterBase
    {
        public PMSUBW(uint rs, uint rt, uint rd, uint sa) 
            : base("PMSUBW", rs, rt, rd, sa)
        {
        }
    }
}
