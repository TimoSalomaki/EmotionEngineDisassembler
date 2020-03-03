namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVZ : RegisterBase
    {
        public MOVZ(int rs, int rt, int rd, int sa, int funct)
            : base("MOVZ", rs, rt, rd, sa, funct)
        {
        }
    }
}
