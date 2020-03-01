namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA32 : RegisterBase
    {
        public DSRA32(string rs, string rt, string rd, string sa, string funct)
            : base("DSRA32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
