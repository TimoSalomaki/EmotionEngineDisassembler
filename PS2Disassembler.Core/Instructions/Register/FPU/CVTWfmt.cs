namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTWfmt : FPURegisterBase
    {
        public CVTWfmt(int fmt, int ft, int fs, int fd)
            : base("CVTWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.W.S {FD}, {FS}" +
                   $"CVT.W.D {FD}, {FS}";
        }
    }
}
