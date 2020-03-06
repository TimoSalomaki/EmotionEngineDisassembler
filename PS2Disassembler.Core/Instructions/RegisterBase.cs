using PS2Disassembler.Core.Helper;

namespace PS2Disassembler.Core.Instructions
{
    public abstract class RegisterBase : InstructionBase
    {
        protected RegisterBase(string op, uint rs, uint rt, uint rd, uint sa, uint funct)
            : base(op)
        {
            RS = RegisterHelper.GetGprRegister(rs);
            RT = RegisterHelper.GetGprRegister(rt);
            RD = RegisterHelper.GetGprRegister(rd);
            SA = "0x" + sa.ToString("X");
            Funct = "0x" + funct.ToString("X"); // Probably not needed
        }

        public string RS { get; set; }
        public string RT { get; set; }
        public string RD { get; set; }
        public string SA { get; set; }
        public string Funct { get; set; }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}, {RT}";
        }
    }
}
