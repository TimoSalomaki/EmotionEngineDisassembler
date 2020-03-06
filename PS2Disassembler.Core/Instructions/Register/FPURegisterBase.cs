namespace PS2Disassembler.Core.Instructions.Register
{
    public abstract class FPURegisterBase : InstructionBase
    {
        protected FPURegisterBase(string op, uint fmt, uint ft, uint fs, uint fd)
            : base(op)
        {
            FMT = "0x" + fmt.ToString("X");
            FT = "0x" + ft.ToString("X");
            FS = "0x" + fs.ToString("X");
            FD = "0x" + fd.ToString("X");
        }

        public string FMT { get; set; }
        public string FT { get; set; }
        public string FS { get; set; }
        public string FD { get; set; }
        public string Funct { get; set; }

        public override string ToString()
        {
            return $"{OP} {FD}, {FS}, {FT}";
        }
    }
}
