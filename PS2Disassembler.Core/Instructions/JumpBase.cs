using System;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class JumpBase : InstructionBase
    {
        public string Target { get; set; }

        protected JumpBase(string op, string target) : base(op)
        {
            Target = "0x" + Convert.ToInt32(target, 2).ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {Target}";
        }
    }
}
