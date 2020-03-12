using PS2Disassembler.Core.Decoder.Instruction;
using PS2Disassembler.Core.Instructions;
using PS2Disassembler.Core.Instructions.Pseudo;

namespace PS2Disassembler.Core
{
    public class InstructionFactory : IInstructionFactory
    { 
        private readonly OpCodeDecoder _opCodeDecoder;
        private readonly ImmediateDecoder _immediateDecoder;
        private readonly JumpDecoder _jumpDecoder;
        private readonly RegimmDecoder _regimmDecoder;
        private readonly RegisterDecoder _registerDecoder;
        private readonly MMIDecoder _mMIDecoder;
        private readonly COP0Decoder _cOP0Decoder;
        private readonly FPUDecoder _fPUDecoder;
        private readonly CACHEDecoder _cACHEDecoder;

        public InstructionFactory()
        {
            _opCodeDecoder = new OpCodeDecoder();
            _immediateDecoder = new ImmediateDecoder();
            _jumpDecoder = new JumpDecoder();
            _regimmDecoder = new RegimmDecoder();
            _registerDecoder = new RegisterDecoder();
            _mMIDecoder = new MMIDecoder();
            _cOP0Decoder = new COP0Decoder();
            _fPUDecoder = new FPUDecoder();
            _cACHEDecoder = new CACHEDecoder();
        }

        public object CreateInstruction(uint input)
        {
            if (input == 0)
                return new NOP();

            var opBin = (input >> 26) & 0x3F;
            
            switch (_opCodeDecoder.GetInstructionType(opBin))
            {
                case InstructionType.Immediate:
                    return _immediateDecoder.Decode(opBin, input);

                case InstructionType.Jump:
                    return _jumpDecoder.Decode(opBin, input);

                case InstructionType.Regimm:
                    return _regimmDecoder.Decode(input);

                case InstructionType.Register:
                    return _registerDecoder.Decode(input);

                case InstructionType.MMI:
                    return _mMIDecoder.Decode(input);

                case InstructionType.Cop0:
                    return _cOP0Decoder.Decode(input);

                case InstructionType.FPU:
                    return _fPUDecoder.Decode(input);

                case InstructionType.CACHE:
                    return _cACHEDecoder.Decode(input);

                default:
                    return new NOP();
            }
        }
    }
}