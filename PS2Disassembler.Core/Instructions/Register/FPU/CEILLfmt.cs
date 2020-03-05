namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CEILLfmt : FPURegisterBase
    {
        public CEILLfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CEILLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CEIL.L.S {FD}, {FS}" +
                   $"CEIL.L.D {FD}, {FS}";
        }
    }
}
