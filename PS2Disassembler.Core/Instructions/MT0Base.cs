﻿using PS2Disassembler.Core.Helper;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class MT0Base : InstructionBase
    {
        protected MT0Base(string op, uint rt, uint rd)
            : base(op)
        {
            RT = RegisterHelper.GetGprRegister(rt);
            RD = RegisterHelper.GetGprRegister(rd);
        }

        public string RT { get; set; }
        public string RD { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}, {RD}";
        }
    }
}
