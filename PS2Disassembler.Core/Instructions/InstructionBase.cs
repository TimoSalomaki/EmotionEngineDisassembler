namespace PS2Disassembler.Core.Instructions
{
    public abstract class InstructionBase
    {
        public InstructionType Type { get; set; }
        public string OP { get; set; }
    }

    public enum InstructionType
    {
        Immediate,
        Jump,
        Register,
        Regimm,
        Nop
    }
}
