namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TEQI : ImmediateBase
    {
        public TEQI(int rs, int rt, int imm) : base("TEQI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
