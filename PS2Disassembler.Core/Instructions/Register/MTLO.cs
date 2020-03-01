namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTLO : RegisterBase
    {
        public MTLO()
        {
            OP = "MTLO";
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
