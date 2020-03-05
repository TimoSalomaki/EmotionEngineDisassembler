namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ROUNDWfmt : FPURegisterBase
    {
        public ROUNDWfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("ROUNDWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ROUND.W.S {FD}, {FS}" +
                   $"ROUND.W.D {FD}, {FS}";
        }
    }
}
