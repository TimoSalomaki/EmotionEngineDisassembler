namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUB : RegisterBase
    {
        public PSUBUB(uint rs, uint rt, uint rd, uint sa) 
            : base("PSUBUB", rs, rt, rd, sa)
        {
        }
    }
}
