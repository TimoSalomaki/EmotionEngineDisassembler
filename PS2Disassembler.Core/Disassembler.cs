using System;
using System.Collections.Generic;
using System.Text;
using PS2Disassembler.Core.Instructions.Factory;

namespace PS2Disassembler.Core
{
    public class Disassembler : IDisassembler
    {
        private readonly IInstructionFactory _instructionFactory;

        public Disassembler()
        {
            _instructionFactory = new InstructionFactory();
        }

        public string Disassemble(int hexInput)
        {
            return _instructionFactory.CreateInstruction(hexInput).OP;
        }

        public string Disassemble(List<int> hexInputList)
        {
            var outputBuilder = new StringBuilder();

            foreach (var hexInput in hexInputList)
            {
                outputBuilder.AppendLine(Disassemble(hexInput));
            }

            return outputBuilder.ToString();
        }
    }
}
