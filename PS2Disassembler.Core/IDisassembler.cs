using System.Collections.Generic;

namespace PS2Disassembler.Core
{
    public interface IDisassembler
    {
        string Disassemble(uint hexInput);
        string Disassemble(List<uint> hexInput);
    }
}
