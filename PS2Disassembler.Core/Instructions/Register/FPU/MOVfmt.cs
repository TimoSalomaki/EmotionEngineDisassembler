﻿namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MOVfmt : FPURegisterBase
    {
        public MOVfmt(int fmt, int ft, int fs, int fd)
            : base("MOVfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"MOV.S {FD}, {FS}" +
                   $"MOV.D {FD}, {FS}";
        }
    }
}