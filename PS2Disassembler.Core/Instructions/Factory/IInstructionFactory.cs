namespace PS2Disassembler.Core.Instructions.Factory
{
    public interface IInstructionFactory
    {
        InstructionBase CreateInstruction(int input);
    }
}
