namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CVTLfmt : FPURegisterBase
    {
        public CVTLfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CVTLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CVT.L.S {FD}, {FS}\n" +
                   $"CVT.L.D {FD}, {FS}";
        }
    }
}
