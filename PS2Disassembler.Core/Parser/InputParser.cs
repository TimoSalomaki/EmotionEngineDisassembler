using System;
using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public class InputParser : IInputParser
    {
        public List<int> ParseContent(string input)
        {
            input = input.Replace("\r", "");
            var lines = input.Split('\n');
            var output = new List<int>();

            foreach (var line in lines)
            {
                var parts = line.Split(' ');

                output.Add(HexPartsToInt(parts[0], parts[1]));

                if(parts.Length > 2)
                    output.Add(HexPartsToInt(parts[2], parts[3]));

                if (parts.Length > 4)
                    output.Add(HexPartsToInt(parts[4], parts[5]));

                if (parts.Length > 6)
                    output.Add(HexPartsToInt(parts[6], parts[7]));
            }

            return output;
        }

        private int HexPartsToInt(string first, string second)
        {
            return Convert.ToInt32($"0x{first}{second}", 16);
        }
    }
}
