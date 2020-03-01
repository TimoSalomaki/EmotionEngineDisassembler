namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRA : RegisterBase
    {
        public SRA()
        {
            OP = "SRA";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT} {SA}";
        }
    }
}
