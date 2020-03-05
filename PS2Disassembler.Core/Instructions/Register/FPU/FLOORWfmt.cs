namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class FLOORWfmt : FPURegisterBase
    {
        public FLOORWfmt(int fmt, int ft, int fs, int fd)
            : base("FLOORWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"FLOOR.W.S {FD}, {FS}" +
                   $"FLOOR.W.D {FD}, {FS}";
        }
    }
}
