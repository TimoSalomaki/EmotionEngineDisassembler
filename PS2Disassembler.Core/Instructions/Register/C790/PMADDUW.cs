namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDUW : RegisterBase
    {
        public PMADDUW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
