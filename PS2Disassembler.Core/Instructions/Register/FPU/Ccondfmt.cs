namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class Ccondfmt : FPURegisterBase
    {
        public Ccondfmt(int fmt, int ft, int fs, int fd)
            : base("Ccondfmt", fmt, ft, fs, fd)
        {
            Cond = "0x" + (fd & 0xF).ToString("X");
        }

        public string Cond { get; set; }

        public override string ToString()
        {
            return $"C.{Cond}.S {FS}, {FT}" +
                   $"C.{Cond}.D {FS}, {FT}";
        }
    }
}
