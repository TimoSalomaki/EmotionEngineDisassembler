namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLLV : RegisterBase
    {
        public DSLLV(string rs, string rt, string rd, string sa, string funct)
            : base("DSLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
