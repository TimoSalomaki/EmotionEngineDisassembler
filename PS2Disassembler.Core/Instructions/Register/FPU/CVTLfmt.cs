namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTLfmt : FPURegisterBase
    {
        public CVTLfmt(int fmt, int ft, int fs, int fd)
            : base("CVTLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.L.S {FD}, {FS}" +
                   $"CVT.L.D {FD}, {FS}";
        }
    }
}
