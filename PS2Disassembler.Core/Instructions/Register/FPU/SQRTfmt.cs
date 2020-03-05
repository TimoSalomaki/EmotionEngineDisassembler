namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class SQRTfmt : FPURegisterBase
    {
        public SQRTfmt(int fmt, int ft, int fs, int fd)
            : base("SQRTfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"SQRT.S {FD}, {FS}" +
                   $"SQRT.D {FD}, {FS}";
        }
    }
}
