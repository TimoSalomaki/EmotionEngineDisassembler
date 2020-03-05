namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MULfmt : FPURegisterBase
    {
        public MULfmt(int fmt, int ft, int fs, int fd)
            : base("MULfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"MUL.S {FD}, {FS}, {FT}" +
                   $"MUL.D {FD}, {FS}, {FT}";
        }
    }
}
