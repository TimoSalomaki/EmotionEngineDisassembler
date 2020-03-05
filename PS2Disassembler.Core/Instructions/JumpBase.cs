using System;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class JumpBase : InstructionBase
    {
        public string Target { get; set; }

        protected JumpBase(string op, uint target) : base(op)
        {
            Target = "0x" + target.ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {Target}";
        }
    }
}
