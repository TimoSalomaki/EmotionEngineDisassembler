namespace PS2Disassembler.Core.Instructions
{
    public class Nop : InstructionBase
    {
        public Nop() : base("NOP")
        {
            Type = InstructionType.Nop;
        }

        public override string ToString()
        {
            return "nop";
        }
    }
}
