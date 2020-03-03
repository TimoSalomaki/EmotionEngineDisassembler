namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYUD : RegisterBase
    {
        public PCPYUD(int rs, int rt, int rd, int sa, int funct) 
            : base("PCPYUD", rs, rt, rd, sa, funct)
        {
        }
    }
}
