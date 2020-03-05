namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MTC1 : FPURegisterBase
    {
        public MTC1(int fmt, int ft, int fs, int fd)
            : base("MTC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
