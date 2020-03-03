namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PINTH : RegisterBase
    {
        public PINTH(int rs, int rt, int rd, int sa, int funct) 
            : base("PINTH", rs, rt, rd, sa, funct)
        {
        }
    }
}
