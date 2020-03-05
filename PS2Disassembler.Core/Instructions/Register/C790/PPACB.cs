﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACB : RegisterBase
    {
        public PPACB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PPACB", rs, rt, rd, sa, funct)
        {
        }
    }
}
