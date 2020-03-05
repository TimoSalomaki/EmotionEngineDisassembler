namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTIU : ImmediateBase
    {
        public TLTIU(uint rs, uint rt, uint imm) : base("TLTIU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
