namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLT : RegisterBase
    {
        public SLT(int rs, int rt, int rd, int sa, int funct)
            : base("SLT", rs, rt, rd, sa, funct)
        {
        }
    }
}
