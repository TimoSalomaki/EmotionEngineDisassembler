namespace PS2Disassembler.Core.Instructions
{
    public abstract class InstructionBase
    {
        public InstructionBase(string op)
        {
            OP = op;
        }

        public InstructionType Type { get; set; }
        public string OP { get; set; }
    }

    public enum InstructionType
    {
        Immediate,
        Jump,
        MMI,
        Register,
        Regimm,
        Nop
    }
}
