namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CFC1 : FPURegisterBase
    {
        public CFC1(int fmt, int ft, int fs, int fd)
            : base("CFC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
