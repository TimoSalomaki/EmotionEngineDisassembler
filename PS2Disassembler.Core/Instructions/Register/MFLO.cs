namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFLO : RegisterBase
    {
        public MFLO()
        {
            OP = "MFLO";
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
