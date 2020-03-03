namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL : RegisterBase
    {
        public DSLL(int rs, int rt, int rd, int sa, int funct)
            : base("DSLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
