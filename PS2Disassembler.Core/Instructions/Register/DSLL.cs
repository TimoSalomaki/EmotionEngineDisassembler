namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL : RegisterBase
    {
        public DSLL(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
