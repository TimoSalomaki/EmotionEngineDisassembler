namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTHI : RegisterBase
    {
        public MTHI()
        {
            OP = "MTHI";
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
