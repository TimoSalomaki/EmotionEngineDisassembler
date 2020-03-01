using System;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public string Imm { get; set; }

        protected ImmediateBase(string op, string rs, string rt, short imm) : base(op)
        {
            RS = rs;
            RT = rt;
            Imm = "0x" + imm.ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
