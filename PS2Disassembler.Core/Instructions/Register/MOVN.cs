namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVN : RegisterBase
    {
        public MOVN(int rs, int rt, int rd, int sa, int funct)
            : base("MOVN", rs, rt, rd, sa, funct)
        {
        }
    }
}
