namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRLV : RegisterBase
    {
        public DSRLV()
        {
            OP = "DSRLV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
