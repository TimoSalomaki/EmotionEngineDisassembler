namespace PS2Disassembler.Core.Instructions
{
    public abstract class InstructionBase
    {
        protected InstructionBase(string op)
        {
            OP = op;
        }

        public string OP { get; set; }
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
        Cop1,
        CACHE
    }
}
