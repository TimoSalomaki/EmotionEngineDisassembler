namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRL : RegisterBase
    {
        public SRL()
        {
            OP = "SRL";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
