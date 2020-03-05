﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PLZCW : RegisterBase
    {
        public PLZCW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PLZCW", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}";
        }
    }
}
