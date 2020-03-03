namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLLV : RegisterBase
    {
        public DSLLV(int rs, int rt, int rd, int sa, int funct)
            : base("DSLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
