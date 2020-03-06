namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRLV : RegisterBase
    {
        public DSRLV(uint rs, uint rt, uint rd, uint sa)
            : base("DSRLV", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
