namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL : RegisterBase
    {
        public DSLL(string rs, string rt, string rd, string sa, string funct)
            : base("DSLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
