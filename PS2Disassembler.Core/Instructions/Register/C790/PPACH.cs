namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACH : RegisterBase
    {
        public PPACH(int rs, int rt, int rd, int sa, int funct) 
            : base("PPACH", rs, rt, rd, sa, funct)
        {
        }
    }
}
