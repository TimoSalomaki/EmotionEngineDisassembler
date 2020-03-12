using System;
using System.Collections.Generic;

namespace PS2Disassembler.Core.Parser
{
    public class InputParser : IInputParser
    {
        public List<uint> ParseContent(ReadOnlySpan<char> input, int lineCount)
        {
            // There's always 4 instructions per line, except maybe on the last line
            var output = new uint[lineCount * 4];
            int outputCounter = 0;

            for (int i = 0; i < lineCount; i++)
            {
                for (int j = 0; j < 39; j += 10)
                {
                    var fullInstruction = input.Slice(i * 41 + j, 9);
                    var nr = Convert.ToUInt32(fullInstruction.ToString().Replace(" ", ""));
                    //output[++outputCounter] = 
                }
            }

            return new List<uint>();

            //input = input.Replace("\r", "").Replace(" ", "");
            //var lines = input.Split('\n');
            //var output = new List<uint>();

            ////foreach (var line in lines)
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    // TODO: Really ugly hack to convert to little endian, FIX!
            //    for (int j = 0; j < lines[i].Length; j += 8)
            //    {
            //        var hex = lines[i].Substring(j, 8);
            //        output.Add(HexPartsToInt($"{hex[6]}{hex[7]}{hex[4]}{hex[5]}{hex[2]}{hex[3]}{hex[0]}{hex[1]}"));
            //    }
            //}
        }

        private uint HexPartsToInt(string input)
        {
            var result = Convert.ToUInt32($"0x{input}", 16);
            
            return result;
        }
    }
}
