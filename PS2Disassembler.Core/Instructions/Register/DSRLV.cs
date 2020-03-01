namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRLV : RegisterBase
    {
        public DSRLV(string rs, string rt, string rd, string sa, string funct)
            : base("DSRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
