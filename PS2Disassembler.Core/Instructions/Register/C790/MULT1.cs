namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULT1 : RegisterBase
    {
        public MULT1(int rs, int rt, int rd, int sa, int funct) 
            : base("MULT1", rs, rt, rd, sa, funct)
        {
        }
    }
}
