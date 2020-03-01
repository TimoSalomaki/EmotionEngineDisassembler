namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEIU : ImmediateBase
    {
        public TGEIU()
        {
            OP = "TGEIU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
