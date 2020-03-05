namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTSfmt : FPURegisterBase
    {
        public CVTSfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CVTSfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.S.D {FD}, {FS}\n" +
                   $"CVT.S.W {FD}, {FS}\n" +
                   $"CVT.S.L {FD}, {FS}";
        }
    }
}
