namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULT : RegisterBase
    {
        public MULT(uint rs, uint rt, uint rd, uint sa) 
            : base("MULT", rs, rt, rd, sa)
        {
        }
    }
}
