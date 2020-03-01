namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLT : RegisterBase
    {
        public TLT()
        {
            OP = "TLT";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
