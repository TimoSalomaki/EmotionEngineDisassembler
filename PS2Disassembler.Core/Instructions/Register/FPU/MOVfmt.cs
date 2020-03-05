namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class MOVfmt : FPURegisterBase
    {
        public MOVfmt(uint fmt, uint ft, uint fs, uint fd)
            : base("MOVfmt", fmt, ft, fs, fd)
        {
        }

        public override string ToString()
        {
            return $"MOV.S {FD}, {FS}\n" +
                   $"MOV.D {FD}, {FS}";
        }
    }
}
