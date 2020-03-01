namespace PS2Disassembler.Core.Instructions.Register
{
    public class BREAK : RegisterBase
    {
        public BREAK()
        {
            OP = "BREAK";
        }

        public override string ToString()
        {
            return "break";
        }
    }
}
