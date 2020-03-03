namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class XORI : ImmediateBase
    {
        public XORI(int rs, int rt, int imm) : base("XORI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
