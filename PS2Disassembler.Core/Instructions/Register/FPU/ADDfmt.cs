namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ADDfmt : FPURegisterBase
    {
        public ADDfmt(int fmt, int ft, int fs, int fd)
            : base("ADDfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ABS.S {FD}, {FS}, {FT}" +
                   $"ABS.D {FD}, {FS}, {FT}";
        }
    }
}
