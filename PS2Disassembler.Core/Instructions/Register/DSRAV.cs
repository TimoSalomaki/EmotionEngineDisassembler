namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRAV : RegisterBase
    {
        public DSRAV(string rs, string rt, string rd, string sa, string funct)
            : base("DSRAV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
