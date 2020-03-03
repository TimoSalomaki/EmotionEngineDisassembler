namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL : RegisterBase
    {
        public DSRL(int rs, int rt, int rd, int sa, int funct)
            : base("DSRL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
