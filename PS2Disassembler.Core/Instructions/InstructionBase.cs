namespace PS2Disassembler.Core.Instructions
{
    public abstract class InstructionBase
    {
        protected InstructionBase(string op)
        {
            OP = op;
        }

        public string OP { get; set; }

        public override string ToString()
        {
            return OP;
        }
    }

    public enum InstructionType
    {
        Immediate,
        Jump,
        MMI,
        Register,
        Regimm,
        Nop,
        Cop0,
        FPU,
        CACHE
    }
}
