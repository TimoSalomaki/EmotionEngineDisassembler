namespace PS2Disassembler.Core.Instructions
{
    public abstract class MSpecial1Base : InstructionBase
    {
        protected MSpecial1Base(string op, int rt, int reg)
            : base(op)
        {
            RT = "0x" + rt.ToString("X");
            REG = "0x" + reg.ToString("X");
        }

        public string RT { get; set; }
        public string REG { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}, {REG}";
        }
    }
}
