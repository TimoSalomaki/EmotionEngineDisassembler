namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRLV : RegisterBase
    {
        public DSRLV(int rs, int rt, int rd, int sa, int funct)
            : base("DSRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
