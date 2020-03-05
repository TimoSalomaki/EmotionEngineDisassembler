namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL32 : RegisterBase
    {
        public DSLL32(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSLL32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
