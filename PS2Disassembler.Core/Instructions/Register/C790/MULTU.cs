namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULTU : RegisterBase
    {
        public MULTU(uint rs, uint rt, uint rd, uint sa) 
            : base("MULTU", rs, rt, rd, sa)
        {
        }
    }
}
