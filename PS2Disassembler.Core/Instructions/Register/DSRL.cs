namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL : RegisterBase
    {
        public DSRL(uint rs, uint rt, uint rd, uint sa)
            : base("DSRL", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
