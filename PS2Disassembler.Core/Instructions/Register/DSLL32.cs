namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSLL32 : RegisterBase
    {
        public DSLL32()
        {
            OP = "DSLL32";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
