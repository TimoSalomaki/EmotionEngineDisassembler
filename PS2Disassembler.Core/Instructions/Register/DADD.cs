namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADD : RegisterBase
    {
        public DADD(int rs, int rt, int rd, int sa, int funct)
            : base("DADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
