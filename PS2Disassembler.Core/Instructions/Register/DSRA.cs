namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA : RegisterBase
    {
        public DSRA(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSRA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
