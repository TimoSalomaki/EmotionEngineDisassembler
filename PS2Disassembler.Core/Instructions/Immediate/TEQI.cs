namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TEQI : ImmediateBase
    {
        public TEQI(string rs, string rt, short imm) : base("TEQI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
