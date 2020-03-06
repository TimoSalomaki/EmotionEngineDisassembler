namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTUW : RegisterBase
    {
        public PMULTUW(uint rs, uint rt, uint rd, uint sa) 
            : base("PMULTUW", rs, rt, rd, sa)
        {
        }
    }
}
