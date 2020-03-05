namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXH : RegisterBase
    {
        public PMAXH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMAXH", rs, rt, rd, sa, funct)
        {
        }
    }
}
