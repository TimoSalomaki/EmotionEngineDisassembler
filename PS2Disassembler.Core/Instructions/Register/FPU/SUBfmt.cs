namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class SUBfmt : FPURegisterBase
    {
        public SUBfmt(int fmt, int ft, int fs, int fd)
            : base("SUBfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"SUB.S {FD}, {FS}, {FT}" +
                   $"SUB.D {FD}, {FS}, {FT}";
        }
    }
}
