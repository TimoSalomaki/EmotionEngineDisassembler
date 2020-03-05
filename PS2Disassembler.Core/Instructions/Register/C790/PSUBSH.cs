﻿namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSH : RegisterBase
    {
        public PSUBSH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSUBSH", rs, rt, rd, sa, funct)
        {
        }
    }
}
