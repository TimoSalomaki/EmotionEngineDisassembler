namespace PS2Disassembler.Core.Instructions.Register
{
    public class TEQ : RegisterBase
    {
        public TEQ()
        {
            OP = "TEQ";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
