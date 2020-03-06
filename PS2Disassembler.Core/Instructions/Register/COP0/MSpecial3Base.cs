using PS2Disassembler.Core.Decoder.Register;

namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public abstract class MSpecial3Base : InstructionBase
    {
        protected MSpecial3Base(string op, uint rt)
            : base(op)
        {
            RT = CPURegisterDecoder.DecodeRegister(rt);
        }

        public string RT { get; set; }

        public override string ToString()
        {
            return $"{OP} {RT}";
        }
    }
}
