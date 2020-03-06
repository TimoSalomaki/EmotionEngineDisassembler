namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PAND : RegisterBase
    {
        public PAND(uint rs, uint rt, uint rd, uint sa) 
            : base("PAND", rs, rt, rd, sa)
        {
        }
    }
}
