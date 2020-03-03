namespace PS2Disassembler.Core.Instructions.Register
{
    public class JR : RegisterBase
    {
        public JR(int rs, int rt, int rd, int sa, int funct)
            : base("JR", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
