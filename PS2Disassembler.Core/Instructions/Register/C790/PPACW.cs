namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACW : RegisterBase
    {
        public PPACW(int rs, int rt, int rd, int sa, int funct) 
            : base("PPACW", rs, rt, rd, sa, funct)
        {
        }
    }
}
