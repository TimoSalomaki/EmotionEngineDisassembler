namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXH : RegisterBase
    {
        public PMAXH(int rs, int rt, int rd, int sa, int funct) 
            : base("PMAXH", rs, rt, rd, sa, funct)
        {
        }
    }
}
