using System;
using PS2Disassembler.Core.Helper;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public string Imm { get; set; }

        protected ImmediateBase(string op, uint rs, uint rt, uint imm) : base(op)
        {
            RS = RegisterHelper.GetGprRegister(rs); 
            RT = RegisterHelper.GetGprRegister(rt);
            Imm = "0x" + imm.ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
