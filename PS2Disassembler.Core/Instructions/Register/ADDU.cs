namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADDU : RegisterBase
    {
        public ADDU(int rs, int rt, int rd, int sa, int funct)
            : base("ADDU", rs, rt, rd, sa, funct)
        {
        }
    }
}
