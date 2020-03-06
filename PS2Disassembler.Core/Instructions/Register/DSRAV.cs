namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRAV : RegisterBase
    {
        public DSRAV(uint rs, uint rt, uint rd, uint sa)
            : base("DSRAV", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
