namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CFC1 : FPURegisterBase
    {
        public CFC1(uint fmt, uint ft, uint fs, uint fd)
            : base("CFC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
