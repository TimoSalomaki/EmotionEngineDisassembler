namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCGTB : RegisterBase
    {
        public PCGTB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCGTB", rs, rt, rd, sa, funct)
        {
        }
    }
}
