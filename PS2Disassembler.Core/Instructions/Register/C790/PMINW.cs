namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMINW : RegisterBase
    {
        public PMINW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMINW", rs, rt, rd, sa, funct)
        {
        }
    }
}
