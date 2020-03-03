namespace PS2Disassembler.Core.Instructions.Register
{
    public class OR : RegisterBase
    {
        public OR(int rs, int rt, int rd, int sa, int funct)
            : base("OR", rs, rt, rd, sa, funct)
        {
        }
    }
}
