namespace PS2Disassembler.Core.Instructions.Register
{
    public class BREAK : RegisterBase
    {
        public BREAK(int rs, int rt, int rd, int sa, int funct)
            : base("BREAK", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "break";
        }
    }
}
