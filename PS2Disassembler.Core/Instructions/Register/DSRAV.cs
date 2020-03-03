namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRAV : RegisterBase
    {
        public DSRAV(int rs, int rt, int rd, int sa, int funct)
            : base("DSRAV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
