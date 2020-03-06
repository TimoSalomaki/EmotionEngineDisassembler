using PS2Disassembler.Core.Decoder.Register;

namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public abstract class MSpecial1Base : InstructionBase
    {
        protected MSpecial1Base(string op, uint rt, uint reg)
            : base(op)
        {
            RT = CPURegisterDecoder.DecodeRegister(rt);
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
