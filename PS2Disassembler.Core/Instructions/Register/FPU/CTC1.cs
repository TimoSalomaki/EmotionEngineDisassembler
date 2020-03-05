namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CTC1 : FPURegisterBase
    {
        public CTC1(int fmt, int ft, int fs, int fd)
            : base("CTC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
