namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDH : RegisterBase
    {
        public PMADDH(uint rs, uint rt, uint rd, uint sa) 
            : base("PMADDH", rs, rt, rd, sa)
        {
        }
    }
}
