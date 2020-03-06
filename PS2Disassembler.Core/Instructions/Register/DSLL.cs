namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL : RegisterBase
    {
        public DSLL(uint rs, uint rt, uint rd, uint sa)
            : base("DSLL", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
