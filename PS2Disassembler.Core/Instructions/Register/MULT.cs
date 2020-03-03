namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULT : RegisterBase
    {
        public MULT(int rs, int rt, int rd, int sa, int funct)
            : base("MULT", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
