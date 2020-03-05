namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTDfmt : FPURegisterBase
    {
        public CVTDfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CVTDfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.D.S {FD}, {FS}\n" +
                   $"CVT.D.W {FD}, {FS}\n" +
                   $"CVT.D.L {FD}, {FS}";
        }
    }
}
