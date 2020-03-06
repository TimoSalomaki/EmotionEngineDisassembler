namespace PS2Disassembler.Core
{
    public interface IInstructionFactory
    {
        object CreateInstruction(uint input);
    }
}
