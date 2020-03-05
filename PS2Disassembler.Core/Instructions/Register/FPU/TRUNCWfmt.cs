namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class TRUNCWfmt : FPURegisterBase
    {
        public TRUNCWfmt(int fmt, int ft, int fs, int fd)
            : base("TRUNCWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"TRUNC.W.S {FD}, {FS}" +
                   $"TRUNC.W.D {FD}, {FS}";
        }
    }
}
