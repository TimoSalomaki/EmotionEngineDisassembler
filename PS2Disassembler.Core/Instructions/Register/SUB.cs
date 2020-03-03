namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUB : RegisterBase
    {
        public SUB(int rs, int rt, int rd, int sa, int funct)
            : base("SUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
