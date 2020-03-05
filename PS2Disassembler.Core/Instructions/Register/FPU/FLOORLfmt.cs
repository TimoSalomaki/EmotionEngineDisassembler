namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class FLOORLfmt : FPURegisterBase
    {
        public FLOORLfmt(int fmt, int ft, int fs, int fd)
            : base("FLOORLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"FLOOR.L.S {FD}, {FS}" +
                   $"FLOOR.L.D {FD}, {FS}";
        }
    }
}
