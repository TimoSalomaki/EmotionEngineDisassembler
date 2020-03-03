namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMSUBW : RegisterBase
    {
        public PMSUBW(int rs, int rt, int rd, int sa, int funct) 
            : base("PMSUBW", rs, rt, rd, sa, funct)
        {
        }
    }
}
