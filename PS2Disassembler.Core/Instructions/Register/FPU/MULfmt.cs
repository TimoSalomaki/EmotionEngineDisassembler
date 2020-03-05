namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MULfmt : FPURegisterBase
    {
        public MULfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("MULfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"MUL.S {FD}, {FS}, {FT}\n" +
                   $"MUL.D {FD}, {FS}, {FT}";
        }
    }
}
