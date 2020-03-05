namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDW : RegisterBase
    {
        public PMADDW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
