namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL : RegisterBase
    {
        public DSLL()
        {
            OP = "DSLL";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
