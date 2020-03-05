namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class ROUNDLfmt : FPURegisterBase
    {
        public ROUNDLfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("ROUNDLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"ROUND.L.S {FD}, {FS}\n" +
                   $"ROUND.L.D {FD}, {FS}";
        }
    }
}
