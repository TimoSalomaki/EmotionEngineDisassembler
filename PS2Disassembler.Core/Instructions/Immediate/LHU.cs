namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LHU : ImmediateBase
    {
        public LHU()
        {
            OP = "LHU";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
