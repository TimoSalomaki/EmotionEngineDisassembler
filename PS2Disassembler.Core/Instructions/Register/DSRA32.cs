namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA32 : RegisterBase
    {
        public DSRA32(uint rs, uint rt, uint rd, uint sa)
            : base("DSRA32", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
