namespace PS2Disassembler.Core.Instructions
{
    public class Nop : InstructionBase
    {
        public Nop() : base("NOP")
        {
        }

        public override string ToString()
        {
            return "NOP";
        }
    }
}
