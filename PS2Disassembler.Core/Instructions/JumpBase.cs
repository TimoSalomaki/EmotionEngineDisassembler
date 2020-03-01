namespace PS2Disassembler.Core.Instructions
{
    public abstract class JumpBase : InstructionBase
    {
        public string Target { get; set; }

        protected JumpBase(string op, string target) : base(op)
        {
            Target = target;
        }

        public override string ToString()
        {
            return $"{OP} {Target}";
        }
    }
}
