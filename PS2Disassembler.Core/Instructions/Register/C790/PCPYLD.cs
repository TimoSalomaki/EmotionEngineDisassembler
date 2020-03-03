namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYLD : RegisterBase
    {
        public PCPYLD(int rs, int rt, int rd, int sa, int funct) 
            : base("PCPYLD", rs, rt, rd, sa, funct)
        {
        }
    }
}
