namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA : RegisterBase
    {
        public DSRA(int rs, int rt, int rd, int sa, int funct)
            : base("DSRA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
