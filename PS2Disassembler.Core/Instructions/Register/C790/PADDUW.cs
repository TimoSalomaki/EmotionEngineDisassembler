namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUW : RegisterBase
    {
        public PADDUW(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDUW", rs, rt, rd, sa)
        {
        }
    }
}
