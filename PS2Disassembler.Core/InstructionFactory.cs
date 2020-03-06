using PS2Disassembler.Core.Decoder.Instruction;
using PS2Disassembler.Core.Instructions;
using PS2Disassembler.Core.Instructions.Pseudo;

namespace PS2Disassembler.Core
{
    public class InstructionFactory : IInstructionFactory
    {
        public object CreateInstruction(uint input)
        {
            if (input == 0)
                return new NOP();

            var opBin = (input >> 26) & 0x3F;
            
            switch (OpCodeDecoder.GetInstructionType(opBin))
            {
                case InstructionType.Immediate:
                    return ImmediateDecoder.Decode(opBin, input);

                case InstructionType.Jump:
                    return JumpDecoder.Decode(opBin, input);

                case InstructionType.Regimm:
                    return RegimmDecoder.Decode(input);

                case InstructionType.Register:
                    return RegisterDecoder.Decode(input);

                case InstructionType.MMI:
                    return MMIDecoder.Decode(input);

                case InstructionType.Cop0:
                    return COP0Decoder.Decode(input);

                case InstructionType.FPU:
                    return FPUDecoder.Decode(input);

                case InstructionType.CACHE:
                    return CACHEDecoder.Decode(input);

                default:
                    return new NOP();
            }
        }
    }
}