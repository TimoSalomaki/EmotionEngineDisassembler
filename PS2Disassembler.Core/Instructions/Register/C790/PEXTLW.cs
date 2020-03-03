namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTLW : RegisterBase
    {
        public PEXTLW(int rs, int rt, int rd, int sa, int funct) 
            : base("PEXTLW", rs, rt, rd, sa, funct)
        {
        }
    }
}
