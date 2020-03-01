namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRAV : RegisterBase
    {
        public DSRAV()
        {
            OP = "DSRAV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
