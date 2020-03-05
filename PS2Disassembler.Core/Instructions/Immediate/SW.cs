namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class SW : ImmediateBase
    {
        public SW(uint rs, uint rt, uint imm) : base("SW", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm} ({RS})"; // Imm = Offset, RS = Base
        }
    }
}
