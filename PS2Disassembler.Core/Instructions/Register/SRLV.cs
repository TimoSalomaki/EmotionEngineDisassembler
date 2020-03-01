namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRLV : RegisterBase
    {
        public SRLV()
        {
            OP = "SRLV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
