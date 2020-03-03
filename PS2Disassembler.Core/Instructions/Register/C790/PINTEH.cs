namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PINTEH : RegisterBase
    {
        public PINTEH(int rs, int rt, int rd, int sa, int funct) 
            : base("PINTEH", rs, rt, rd, sa, funct)
        {
        }
    }
}
