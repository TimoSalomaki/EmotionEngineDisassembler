namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ADDfmt : FPURegisterBase
    {
        public ADDfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("ADDfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ABS.S {FD}, {FS}, {FT}\n" +
                   $"ABS.D {FD}, {FS}, {FT}";
        }
    }
}
