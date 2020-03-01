namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEIU : ImmediateBase
    {
        public TGEIU(string rs, string rt, short imm) : base("TGEIU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
