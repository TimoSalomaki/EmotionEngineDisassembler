namespace PS2Disassembler.Core.Instructions.Factory
{
    public interface IInstructionFactory
    {
        object CreateInstruction(uint input);
    }
}
