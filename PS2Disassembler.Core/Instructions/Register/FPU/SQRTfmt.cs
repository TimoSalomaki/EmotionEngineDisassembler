namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class SQRTfmt : FPURegisterBase
    {
        public SQRTfmt(uint fmt, uint ft, uint fs, uint fd)
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
