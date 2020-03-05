namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLB : RegisterBase
    {
        public PEXTLB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXTLB", rs, rt, rd, sa, funct)
        {
        }
    }
}
