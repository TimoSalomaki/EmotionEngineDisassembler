namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSW : RegisterBase
    {
        public PADDSW(int rs, int rt, int rd, int sa, int funct) 
            : base("PADDSW", rs, rt, rd, sa, funct)
        {
        }
    }
}
