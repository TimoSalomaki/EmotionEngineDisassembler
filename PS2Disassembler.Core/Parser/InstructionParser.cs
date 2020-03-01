namespace PS2Disassembler.Core.Parser
{
    public class InstructionParser : IInstructionParser
    {
        // Super simple now but will be extended and generalized more in the future
        public string GetBinary(string input, int start, int length)
        {
            return input.Substring(start, length);
        }
    }
}
