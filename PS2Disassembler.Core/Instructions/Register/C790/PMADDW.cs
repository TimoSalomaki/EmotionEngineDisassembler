namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMADDW : RegisterBase
    {
        public PMADDW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
