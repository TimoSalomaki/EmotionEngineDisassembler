namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGEU : RegisterBase
    {
        public TGEU()
        {
            OP = "TGEU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
