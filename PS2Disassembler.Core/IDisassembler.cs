using System.Collections.Generic;

namespace PS2Disassembler.Core
{
    public interface IDisassembler
    {
        string Disassemble(int hexInput);
        string Disassemble(List<int> hexInput);
    }
}
