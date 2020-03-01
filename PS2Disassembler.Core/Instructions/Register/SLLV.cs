namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLLV : RegisterBase
    {
        public SLLV()
        {
            OP = "SLLV";
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
