namespace PS2Disassembler.Core.Instructions
{
    public abstract class RegisterBase : InstructionBase
    {
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
