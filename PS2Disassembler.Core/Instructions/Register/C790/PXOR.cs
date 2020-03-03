namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PXOR : RegisterBase
    {
        public PXOR(int rs, int rt, int rd, int sa, int funct) 
            : base("PXOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
