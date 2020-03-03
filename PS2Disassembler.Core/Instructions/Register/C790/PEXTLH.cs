namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLH : RegisterBase
    {
        public PEXTLH(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTLH", rs, rt, rd, sa, funct)
        {
        }
    }
}
