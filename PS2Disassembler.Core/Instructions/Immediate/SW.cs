namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SW : ImmediateBase
    {
        public SW()
        {
            OP = "SW";
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
