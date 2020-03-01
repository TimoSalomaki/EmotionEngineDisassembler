namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TEQI : ImmediateBase
    {
        public TEQI()
        {
            OP = "TEQI";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
