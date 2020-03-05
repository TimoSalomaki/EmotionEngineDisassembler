namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ABSfmt : FPURegisterBase
    {
        public ABSfmt(int fmt, int ft, int fs, int fd) 
            : base("ABSfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ABS.S {FD}, {FS}" +
                   $"ABS.D {FD}, {FS}";
        }
    }
}
