using PS2Disassembler.Core.Instructions.Jump;

namespace PS2Disassembler.Core.Decoder.Instruction
{
    public class JumpDecoder : InstructionDecoderBase
    {
        public object Decode(uint opCode, uint bits)
        {
            var classType = opCode == 2 ? typeof(J) : typeof(JAL);
            var args = new object[]
            {
                bits & 0x3FFFFFF,
            };

            return GetInstance(classType, args);
        }
    }
}
