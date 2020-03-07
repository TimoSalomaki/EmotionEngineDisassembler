using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS2Disassembler.Core
{
    public interface IDisassembler
    {
        string Disassemble(uint hexInput);
        string Disassemble(List<uint> hexInput);
        Task<(string result, TimeSpan parseDuration, TimeSpan decodeDuration)> DisassembleNonParsedInput(string input, int lineCount, int blockCount = 128, int maxThreads = 8);
    }
}
