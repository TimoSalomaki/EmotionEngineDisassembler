namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRA : RegisterBase
    {
        public DSRA()
        {
            OP = "DSRA";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
