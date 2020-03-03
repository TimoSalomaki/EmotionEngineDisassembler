namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACB : RegisterBase
    {
        public PPACB(int rs, int rt, int rd, int sa, int funct) 
            : base("PPACB", rs, rt, rd, sa, funct)
        {
        }
    }
}
