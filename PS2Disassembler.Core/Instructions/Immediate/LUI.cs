namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LUI : ImmediateBase
    {
        public LUI(uint rs, uint rt, uint imm) : base("LUI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm}";
        }
    }
}
