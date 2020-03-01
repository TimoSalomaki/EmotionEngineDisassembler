namespace PS2Disassembler.Core.Instructions.Register
{
    public class JR : RegisterBase
    {
        public JR()
        {
            OP = "JR";
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
