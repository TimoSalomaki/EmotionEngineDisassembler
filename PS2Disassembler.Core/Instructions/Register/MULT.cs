namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULT : RegisterBase
    {
        public MULT()
        {
            OP = "MULT";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
