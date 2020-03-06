using PS2Disassembler.Core.Decoder.Register;

namespace PS2Disassembler.Core.Instructions.Register
{
    public abstract class RegisterBase : InstructionBase
    {
        protected RegisterBase(string op, uint rs, uint rt, uint rd, uint sa)
            : base(op)
        {
            RS = CPURegisterDecoder.DecodeRegister(rs);
            RT = CPURegisterDecoder.DecodeRegister(rt);
            RD = CPURegisterDecoder.DecodeRegister(rd);
            SA = "0x" + sa.ToString("X");
        }

        public string RS { get; set; }
        public string RT { get; set; }
        public string RD { get; set; }
        public string SA { get; set; }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}, {RT}";
        }
    }
}
