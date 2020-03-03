namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDH : RegisterBase
    {
        public PMADDH(int rs, int rt, int rd, int sa, int funct) 
            : base("PMADDH", rs, rt, rd, sa, funct)
        {
        }
    }
}
