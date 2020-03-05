namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class TRUNCLfmt : FPURegisterBase
    {
        public TRUNCLfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("TRUNCLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"TRUNC.L.S {FD}, {FS}\n" +
                   $"TRUNC.L.D {FD}, {FS}";
        }
    }
}
