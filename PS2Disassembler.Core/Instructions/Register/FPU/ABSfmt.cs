namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ABSfmt : FPURegisterBase
    {
        public ABSfmt(uint fmt, uint ft, uint fs, uint fd) 
            : base("ABSfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ABS.S {FD}, {FS}" +
                   $"ABS.D {FD}, {FS}";
        }
    }
}
