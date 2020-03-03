namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLTU : RegisterBase
    {
        public SLTU(int rs, int rt, int rd, int sa, int funct)
            : base("SLTU", rs, rt, rd, sa, funct)
        {
        }
    }
}
