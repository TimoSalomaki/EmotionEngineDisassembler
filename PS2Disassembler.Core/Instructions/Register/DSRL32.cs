namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL32 : RegisterBase
    {
        public DSRL32(uint rs, uint rt, uint rd, uint sa)
            : base("DSRL32", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
