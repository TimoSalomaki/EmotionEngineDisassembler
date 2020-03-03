namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBW : RegisterBase
    {
        public PSUBW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBW", rs, rt, rd, sa, funct)
        {
        }
    }
}
