namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class NEGfmt : FPURegisterBase
    {
        public NEGfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("NEGfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"NEG.S {FD}, {FS}\n" +
                   $"NEG.D {FD}, {FS}";
        }
    }
}
