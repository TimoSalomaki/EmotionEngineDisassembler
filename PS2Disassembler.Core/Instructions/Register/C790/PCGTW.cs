namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCGTW : RegisterBase
    {
        public PCGTW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCGTW", rs, rt, rd, sa, funct)
        {
        }
    }
}
