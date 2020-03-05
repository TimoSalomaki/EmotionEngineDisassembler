namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class TRUNCWfmt : FPURegisterBase
    {
        public TRUNCWfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("TRUNCWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"TRUNC.W.S {FD}, {FS}\n" +
                   $"TRUNC.W.D {FD}, {FS}";
        }
    }
}
