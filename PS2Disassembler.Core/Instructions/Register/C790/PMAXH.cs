namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXH : RegisterBase
    {
        public PMAXH(uint rs, uint rt, uint rd, uint sa) 
            : base("PMAXH", rs, rt, rd, sa)
        {
        }
    }
}
