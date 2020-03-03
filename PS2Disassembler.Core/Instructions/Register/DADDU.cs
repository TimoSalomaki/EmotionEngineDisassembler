namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADDU : RegisterBase
    {
        public DADDU(int rs, int rt, int rd, int sa, int funct)
            : base("DADDU", rs, rt, rd, sa, funct)
        {
        }
    }
}
