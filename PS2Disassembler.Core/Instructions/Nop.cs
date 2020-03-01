namespace PS2Disassembler.Core.Instructions
{
    public class Nop : InstructionBase
    {
        public Nop()
        {
            OP = "nop";
            Type = InstructionType.Nop;
        }

        public override string ToString()
        {
            return "nop";
        }
    }
}
