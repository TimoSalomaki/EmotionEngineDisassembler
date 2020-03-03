namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PAND : RegisterBase
    {
        public PAND(int rs, int rt, int rd, int sa, int funct) 
            : base("PAND", rs, rt, rd, sa, funct)
        {
        }
    }
}
