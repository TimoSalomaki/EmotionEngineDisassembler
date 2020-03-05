namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CTC1 : FPURegisterBase
    {
        public CTC1(uint fmt, uint ft, uint fs, uint fd)
            : base("CTC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
