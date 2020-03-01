using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public interface IInputParser
    {
        List<int> ParseContent(string input);
    }
}
