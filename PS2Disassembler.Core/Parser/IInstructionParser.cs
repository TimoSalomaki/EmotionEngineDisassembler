namespace PS2Disassembler.Core.Parser
{
    public interface IInstructionParser
    {
        string GetBinary(string input, int start, int length);
    }
}