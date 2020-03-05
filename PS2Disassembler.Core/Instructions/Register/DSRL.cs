namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL : RegisterBase
    {
        public DSRL(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSRL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
