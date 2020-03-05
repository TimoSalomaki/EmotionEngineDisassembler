namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class DMTC1 : FPURegisterBase
    {
        public DMTC1(int fmt, int ft, int fs, int fd)
            : base("DMTC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
