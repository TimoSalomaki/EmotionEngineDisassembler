using System;
using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public class InputParser : IInputParser
    {
        public List<int> ParseContent(string input)
        {
            input = input.Replace("\r", "").Replace(" ", "");
            var lines = input.Split('\n');
            var output = new List<int>();

            //foreach (var line in lines)
            for(int i = 0; i < lines.Length; i++)
            {
                // TODO: Really ugly hack to convert to little endian, FIX!
                for (int j = 0; j < lines[i].Length; j += 8)
                {
                    var hex = lines[i].Substring(j, 8);
                    output.Add(HexPartsToInt($"{hex[6]}{hex[7]}{hex[4]}{hex[5]}{hex[2]}{hex[3]}{hex[0]}{hex[1]}"));
                }
            }

            return output;
        }

        private int HexPartsToInt(string input)
        {
            var result = Convert.ToInt32($"0x{input}", 16);
            
            return result;
        }
    }
}
