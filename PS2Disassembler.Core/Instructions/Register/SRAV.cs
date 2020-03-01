namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRAV : RegisterBase
    {
        public SRAV()
        {
            OP = "SRAV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
