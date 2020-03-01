namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTIU : ImmediateBase
    {
        public TLTIU(string rs, string rt, short imm) : base("TLTIU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
