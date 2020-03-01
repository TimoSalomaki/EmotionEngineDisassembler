namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL : RegisterBase
    {
        public DSRL(string rs, string rt, string rd, string sa, string funct)
            : base("DSRL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
