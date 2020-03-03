namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA32 : RegisterBase
    {
        public DSRA32(int rs, int rt, int rd, int sa, int funct)
            : base("DSRA32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
