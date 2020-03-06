namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUW : RegisterBase
    {
        public PSUBUW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSUBUW", rs, rt, rd, sa)
        {
        }
    }
}
