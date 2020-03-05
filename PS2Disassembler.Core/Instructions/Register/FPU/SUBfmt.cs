namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class SUBfmt : FPURegisterBase
    {
        public SUBfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("SUBfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"SUB.S {FD}, {FS}, {FT}\n" +
                   $"SUB.D {FD}, {FS}, {FT}";
        }
    }
}
