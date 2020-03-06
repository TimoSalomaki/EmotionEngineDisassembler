namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUW : RegisterBase
    {
        public PEXTUW(uint rs, uint rt, uint rd, uint sa) 
            : base("PEXTUW", rs, rt, rd, sa)
        {
        }
    }
}
