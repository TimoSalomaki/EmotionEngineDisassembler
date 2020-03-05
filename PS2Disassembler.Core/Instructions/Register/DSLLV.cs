namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLLV : RegisterBase
    {
        public DSLLV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DSLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
