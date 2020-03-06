namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUB : RegisterBase
    {
        public PEXTUB(uint rs, uint rt, uint rd, uint sa) 
            : base("PEXTUB", rs, rt, rd, sa)
        {
        }
    }
}
