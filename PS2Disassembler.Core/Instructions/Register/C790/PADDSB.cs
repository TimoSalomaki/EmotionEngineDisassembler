namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSB : RegisterBase
    {
        public PADDSB(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
