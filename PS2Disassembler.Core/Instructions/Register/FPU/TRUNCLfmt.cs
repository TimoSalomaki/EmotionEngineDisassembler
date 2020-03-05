namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class TRUNCLfmt : FPURegisterBase
    {
        public TRUNCLfmt(int fmt, int ft, int fs, int fd)
            : base("TRUNCLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"TRUNC.L.S {FD}, {FS}" +
                   $"TRUNC.L.D {FD}, {FS}";
        }
    }
}
