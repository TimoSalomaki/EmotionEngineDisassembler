namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBH : RegisterBase
    {
        public PSUBH(uint rs, uint rt, uint rd, uint sa) 
            : base("PSUBH", rs, rt, rd, sa)
        {
        }
    }
}
