namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDB : RegisterBase
    {
        public PADDB(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDB", rs, rt, rd, sa)
        {
        }
    }
}
