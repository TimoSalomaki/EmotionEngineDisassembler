namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class CEILWfmt : FPURegisterBase
    {
        public CEILWfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("CEILWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"CEIL.W.S {FD}, {FS}\n" +
                   $"CEIL.W.D {FD}, {FS}";
        }
    }
}
