namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULTU1 : RegisterBase
    {
        public MULTU1(int rs, int rt, int rd, int sa, int funct) 
            : base("MULTU1", rs, rt, rd, sa, funct)
        {
        }
    }
}
