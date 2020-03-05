namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MTC1 : FPURegisterBase
    {
        public MTC1(uint fmt, uint ft, uint fs, uint fd)
            : base("MTC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
