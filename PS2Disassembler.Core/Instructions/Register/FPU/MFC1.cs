namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MFC1 : FPURegisterBase
    {
        public MFC1(uint fmt, uint ft, uint fs, uint fd)
            : base("MFC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
