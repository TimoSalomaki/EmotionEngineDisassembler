using System;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public string Imm { get; set; }

        protected ImmediateBase(string op, int rs, int rt, int imm) : base(op)
        {
            RS = "0x" + rs.ToString("X"); 
            RT = "0x" + rt.ToString("X");
            Imm = "0x" + imm.ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
