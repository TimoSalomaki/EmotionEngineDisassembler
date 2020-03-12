using System;
using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public interface IInputParser
    {
        List<uint> ParseContent(ReadOnlySpan<char> input, int lineCount);
    }
}
