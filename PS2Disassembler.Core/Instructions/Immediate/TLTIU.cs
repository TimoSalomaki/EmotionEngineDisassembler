namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTIU : ImmediateBase
    {
        public TLTIU()
        {
            OP = "TLTIU";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
