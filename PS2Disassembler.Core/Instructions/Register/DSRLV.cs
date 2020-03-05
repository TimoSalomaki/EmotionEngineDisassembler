namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRLV : RegisterBase
    {
        public DSRLV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
