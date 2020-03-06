﻿using PS2Disassembler.Core.Decoder.Register;

namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MFC0 : InstructionBase
    {
        public MFC0(uint rt, uint rd)
            : base("MFC0")
        {
            RT = CPURegisterDecoder.DecodeRegister(rt);
            RD = CPURegisterDecoder.DecodeRegister(rd);
        }

        public string RT { get; set; }
        public string RD { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}, {RD}";
        }
    }
}
