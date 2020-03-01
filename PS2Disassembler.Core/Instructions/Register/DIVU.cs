namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIVU : RegisterBase
    {
        public DIVU()
        {
            OP = "DIVU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
