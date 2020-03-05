namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class DIVfmt : FPURegisterBase
    {
        public DIVfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("DIVfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"DIV.S {FD}, {FS}, {FT}\n" +
                   $"DIV.D {FD}, {FS}, {FT}";
        }
    }
}
