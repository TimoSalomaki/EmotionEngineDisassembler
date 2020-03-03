namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCGTW : RegisterBase
    {
        public PCGTW(int rs, int rt, int rd, int sa, int funct) 
            : base("PCGTW", rs, rt, rd, sa, funct)
        {
        }
    }
}
