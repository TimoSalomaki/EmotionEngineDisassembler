namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class XORI : ImmediateBase
    {
        public XORI(string rs, string rt, short imm) : base("XORI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RS}, {Imm}";
        }
    }
}
