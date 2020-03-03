namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULTU : RegisterBase
    {
        public MULTU(int rs, int rt, int rd, int sa, int funct)
            : base("MULTU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
