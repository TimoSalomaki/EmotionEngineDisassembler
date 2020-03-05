namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CEILWfmt : FPURegisterBase
    {
        public CEILWfmt(int fmt, int ft, int fs, int fd)
            : base("CEILWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CEIL.W.S {FD}, {FS}" +
                   $"CEIL.W.D {FD}, {FS}";
        }
    }
}
