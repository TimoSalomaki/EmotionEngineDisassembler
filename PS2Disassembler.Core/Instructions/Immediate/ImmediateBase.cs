using PS2Disassembler.Core.Decoder.Register;

namespace PS2Disassembler.Core.Instructions.Immediate
{
    public abstract class ImmediateBase : InstructionBase
    {
        public string RS { get; set; }
        public string RT { get; set; }
        public string Imm { get; set; }

        protected ImmediateBase(string op, uint rs, uint rt, uint imm) : base(op)
        {
            RS = CPURegisterDecoder.DecodeRegister(rs); 
            RT = CPURegisterDecoder.DecodeRegister(rt);
            Imm = "0x" + imm.ToString("X");
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
