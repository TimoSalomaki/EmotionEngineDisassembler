namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ROUNDWfmt : FPURegisterBase
    {
        public ROUNDWfmt(int fmt, int ft, int fs, int fd)
            : base("ROUNDWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ROUND.W.S {FD}, {FS}" +
                   $"ROUND.W.D {FD}, {FS}";
        }
    }
}
