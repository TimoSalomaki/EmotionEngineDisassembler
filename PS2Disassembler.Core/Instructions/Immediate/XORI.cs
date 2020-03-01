namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class XORI : ImmediateBase
    {
        public XORI()
        {
            OP = "XORI";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
