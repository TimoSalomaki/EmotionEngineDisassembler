namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PNOR : RegisterBase
    {
        public PNOR(uint rs, uint rt, uint rd, uint sa) 
            : base("PNOR", rs, rt, rd, sa)
        {
        }
    }
}
