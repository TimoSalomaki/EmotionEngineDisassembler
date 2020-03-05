using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public interface IInputParser
    {
        List<uint> ParseContent(string input);
    }
}
