namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class NEGfmt : FPURegisterBase
    {
        public NEGfmt(int fmt, int ft, int fs, int fd)
            : base("NEGfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"NEG.S {FD}, {FS}" +
                   $"NEG.D {FD}, {FS}";
        }
    }
}
