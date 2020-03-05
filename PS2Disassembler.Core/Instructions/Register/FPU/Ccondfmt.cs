namespace PS2Disassembler.Core.Instructions.Register.FPU
{
    public class Ccondfmt : FPURegisterBase
    {
        public Ccondfmt(uint fmt, uint ft, uint fs, uint fd, string condMnemonic)
            : base("Ccondfmt", fmt, ft, fs, fd)
        {
            FMT = "0x" + fmt.ToString("X");
            FT = "0x" + ft.ToString("X");
            FS = "0x" + fs.ToString("X");
            FD = "0x" + fd.ToString("X");
            CondMnemonic = condMnemonic;
        }

        public string CondMnemonic { get; set; }

        public override string ToString()
        {
            return $"C.{CondMnemonic}.S {FS}, {FT}\n" +
                   $"C.{CondMnemonic}.D {FS}, {FT}";
        }
    }
}
