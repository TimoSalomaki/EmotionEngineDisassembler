namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLLV : RegisterBase
    {
        public DSLLV()
        {
            OP = "DSLLV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
