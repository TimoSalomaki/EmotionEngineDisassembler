namespace PS2Disassembler.Core.Instructions.Register
{
    public class XOR : RegisterBase
    {
        public XOR(int rs, int rt, int rd, int sa, int funct)
            : base("XOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
