namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA32 : RegisterBase
    {
        public DSRA32(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSRA32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
