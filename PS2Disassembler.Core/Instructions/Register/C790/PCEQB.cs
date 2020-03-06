namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCEQB : RegisterBase
    {
        public PCEQB(uint rs, uint rt, uint rd, uint sa) 
            : base("PCEQB", rs, rt, rd, sa)
        {
        }
    }
}
