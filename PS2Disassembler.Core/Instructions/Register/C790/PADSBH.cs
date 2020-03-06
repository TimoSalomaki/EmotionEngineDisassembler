namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADSBH : RegisterBase
    {
        public PADSBH(uint rs, uint rt, uint rd, uint sa) 
            : base("PADSBH", rs, rt, rd, sa)
        {
        }
    }
}
