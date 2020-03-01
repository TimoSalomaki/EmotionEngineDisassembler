namespace PS2Disassembler.Core.Instructions.Register
{
    public class TNE : RegisterBase
    {
        public TNE()
        {
            OP = "TNE";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
