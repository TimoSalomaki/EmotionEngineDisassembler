namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBUH : RegisterBase
    {
        public PSUBUH(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBUH", rs, rt, rd, sa, funct)
        {
        }
    }
}
