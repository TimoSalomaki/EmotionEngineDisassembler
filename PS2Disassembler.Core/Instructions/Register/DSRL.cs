namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSRL : RegisterBase
    {
        public DSRL()
        {
            OP = "DSRL";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
