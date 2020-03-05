namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class DMFC1 : FPURegisterBase
    {
        public DMFC1(uint fmt, uint ft, uint fs, uint fd)
            : base("DMFC1", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"{OP} {FT}, {FS}"; // FT = RT
        }
    }
}
