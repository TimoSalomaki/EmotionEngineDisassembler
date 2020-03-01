namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULTU : RegisterBase
    {
        public MULTU()
        {
            OP = "MULTU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
