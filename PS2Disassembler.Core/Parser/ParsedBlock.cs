using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public struct ParsedBlock
    {
        public ParsedBlock(int index, int start, List<uint> lines)
        {
            Index = index;
            Start = start;
            Lines = lines;
        }

        public int Index { get; set; }
        public int Start { get; set; }
        public List<uint> Lines { get; set; }
    }
}
