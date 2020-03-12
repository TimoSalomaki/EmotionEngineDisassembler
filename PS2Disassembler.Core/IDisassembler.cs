using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS2Disassembler.Core
{
    public interface IDisassembler
    {
        string Disassemble(uint hexInput);
        string Disassemble(List<uint> hexInput);
        Task<(string result, TimeSpan parseDuration, TimeSpan decodeDuration)> DisassembleNonParsedInput(ReadOnlySpan<char> input, int lineCount, int blockCount = 128, int maxThreads = 8);
        (string result, TimeSpan decodeDuration) DisassembleByteArrays(List<byte[]> input, int maxThreads = 4);
        void DisassembleByteArray(byte[] input, int inputLength, ref StringBuilder sBuilder, int maxThreads = 4);
    }
}
