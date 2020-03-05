namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class DIVfmt : FPURegisterBase
    {
        public DIVfmt(int fmt, int ft, int fs, int fd)
            : base("DIVfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"DIV.S {FD}, {FS}, {FT}" +
                   $"DIV.D {FD}, {FS}, {FT}";
        }
    }
}
