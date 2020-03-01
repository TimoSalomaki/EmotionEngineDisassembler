namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA : RegisterBase
    {
        public DSRA(string rs, string rt, string rd, string sa, string funct)
            : base("DSRA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
