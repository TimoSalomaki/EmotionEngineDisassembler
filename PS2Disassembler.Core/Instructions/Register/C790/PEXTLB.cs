namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLB : RegisterBase
    {
        public PEXTLB(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTLB", rs, rt, rd, sa, funct)
        {
        }
    }
}
