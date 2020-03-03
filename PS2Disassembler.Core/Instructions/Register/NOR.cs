namespace PS2Disassembler.Core.Instructions.Register
{
    public class NOR : RegisterBase
    {
        public NOR(int rs, int rt, int rd, int sa, int funct)
            : base("NOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
