namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA : RegisterBase
    {
        public DSRA(uint rs, uint rt, uint rd, uint sa)
            : base("DSRA", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
