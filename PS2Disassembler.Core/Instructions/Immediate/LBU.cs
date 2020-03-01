namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LBU : ImmediateBase
    {
        public LBU()
        {
            OP = "LBU";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
