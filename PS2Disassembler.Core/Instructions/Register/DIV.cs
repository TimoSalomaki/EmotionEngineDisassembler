namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIV : RegisterBase
    {
        public DIV()
        {
            OP = "DIV";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
