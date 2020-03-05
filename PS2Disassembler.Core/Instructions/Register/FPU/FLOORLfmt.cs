namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class FLOORLfmt : FPURegisterBase
    {
        public FLOORLfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("FLOORLfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"FLOOR.L.S {FD}, {FS}" +
                   $"FLOOR.L.D {FD}, {FS}";
        }
    }
}
