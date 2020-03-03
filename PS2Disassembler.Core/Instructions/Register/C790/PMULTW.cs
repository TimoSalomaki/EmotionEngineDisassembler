namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTW : RegisterBase
    {
        public PMULTW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMULTW", rs, rt, rd, sa, funct)
        {
        }
    }
}
