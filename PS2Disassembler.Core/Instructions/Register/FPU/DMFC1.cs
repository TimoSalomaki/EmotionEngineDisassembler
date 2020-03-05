namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class DMFC1 : FPURegisterBase
    {
        public DMFC1(int fmt, int ft, int fs, int fd)
            : base("DMFC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
