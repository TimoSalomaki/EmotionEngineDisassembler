namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUH : RegisterBase
    {
        public PSUBUH(uint rs, uint rt, uint rd, uint sa) 
            : base("PSUBUH", rs, rt, rd, sa)
        {
        }
    }
}
