namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL32 : RegisterBase
    {
        public DSLL32(string rs, string rt, string rd, string sa, string funct)
            : base("DSLL32", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
