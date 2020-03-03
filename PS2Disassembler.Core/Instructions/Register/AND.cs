namespace PS2Disassembler.Core.Instructions.Register
{
    public class AND : RegisterBase
    {
        public AND(int rs, int rt, int rd, int sa, int funct)
            : base("AND", rs, rt, rd, sa, funct)
        {
        }
    }
}
