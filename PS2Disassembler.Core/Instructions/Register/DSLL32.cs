namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL32 : RegisterBase
    {
        public DSLL32(int rs, int rt, int rd, int sa, int funct)
            : base("DSLL32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
