namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LUI : ImmediateBase
    {
        public LUI()
        {
            OP = "LUI";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm}";
        }
    }
}
