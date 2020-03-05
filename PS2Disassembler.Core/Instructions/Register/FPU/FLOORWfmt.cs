namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class FLOORWfmt : FPURegisterBase
    {
        public FLOORWfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("FLOORWfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"FLOOR.W.S {FD}, {FS}" +
                   $"FLOOR.W.D {FD}, {FS}";
        }
    }
}
