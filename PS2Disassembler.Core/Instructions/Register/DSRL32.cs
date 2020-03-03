namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL32 : RegisterBase
    {
        public DSRL32(int rs, int rt, int rd, int sa, int funct)
            : base("DSRL32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
