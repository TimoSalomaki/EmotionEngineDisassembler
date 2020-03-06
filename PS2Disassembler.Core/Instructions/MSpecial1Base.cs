using PS2Disassembler.Core.Helper;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class MSpecial1Base : InstructionBase
    {
        protected MSpecial1Base(string op, uint rt, uint reg)
            : base(op)
        {
            RT = RegisterHelper.GetGprRegister(rt);
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
