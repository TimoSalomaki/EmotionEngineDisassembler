namespace PS2Disassembler.Core.Instructions
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public short Imm { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
