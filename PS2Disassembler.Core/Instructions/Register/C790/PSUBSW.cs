namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSW : RegisterBase
    {
        public PSUBSW(int rs, int rt, int rd, int sa, int funct) 
            : base("PSUBSW", rs, rt, rd, sa, funct)
        {
        }
    }
}
