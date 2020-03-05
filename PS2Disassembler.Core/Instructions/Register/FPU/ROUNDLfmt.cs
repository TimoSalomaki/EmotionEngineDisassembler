namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ROUNDLfmt : FPURegisterBase
    {
        public ROUNDLfmt(int fmt, int ft, int fs, int fd)
            : base("ROUNDLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ROUND.L.S {FD}, {FS}" +
                   $"ROUND.L.D {FD}, {FS}";
        }
    }
}
