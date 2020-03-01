namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFHI : RegisterBase
    {
        public MFHI()
        {
            OP = "MFHI";
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
