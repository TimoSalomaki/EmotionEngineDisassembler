namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA32 : RegisterBase
    {
        public DSRA32()
        {
            OP = "DSRA32";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
