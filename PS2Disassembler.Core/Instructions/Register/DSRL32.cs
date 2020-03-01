namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL32 : RegisterBase
    {
        public DSRL32()
        {
            OP = "DSRL32";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
