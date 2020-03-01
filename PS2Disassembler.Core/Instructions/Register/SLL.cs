namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLL : RegisterBase
    {
        public SLL()
        {
            OP = "SLL";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
