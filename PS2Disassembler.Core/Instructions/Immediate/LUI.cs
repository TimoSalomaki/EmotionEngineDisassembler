namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class LUI : ImmediateBase
    {
        public LUI(int rs, int rt, int imm) : base("LUI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {Imm}";
        }
    }
}
