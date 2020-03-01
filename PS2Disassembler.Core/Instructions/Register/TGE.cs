namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGE : RegisterBase
    {
        public TGE()
        {
            OP = "TGE";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
