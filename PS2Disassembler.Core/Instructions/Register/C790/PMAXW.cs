namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMAXW : RegisterBase
    {
        public PMAXW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMAXW", rs, rt, rd, sa, funct)
        {
        }
    }
}
