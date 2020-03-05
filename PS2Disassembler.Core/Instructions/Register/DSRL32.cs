namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL32 : RegisterBase
    {
        public DSRL32(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSRL32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
