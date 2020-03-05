﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSW : RegisterBase
    {
        public PABSW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PABSW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
