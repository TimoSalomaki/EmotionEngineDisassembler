namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLTU : RegisterBase
    {
        public TLTU()
        {
            OP = "TLTU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
