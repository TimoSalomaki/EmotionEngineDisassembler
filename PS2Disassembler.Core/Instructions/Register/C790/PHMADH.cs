namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PHMADH : RegisterBase
    {
        public PHMADH(int rs, int rt, int rd, int sa, int funct) 
            : base("PHMADH", rs, rt, rd, sa, funct)
        {
        }
    }
}
