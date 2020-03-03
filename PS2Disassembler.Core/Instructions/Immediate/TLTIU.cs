namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTIU : ImmediateBase
    {
        public TLTIU(int rs, int rt, int imm) : base("TLTIU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
