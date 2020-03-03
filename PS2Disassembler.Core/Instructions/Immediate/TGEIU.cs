namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEIU : ImmediateBase
    {
        public TGEIU(int rs, int rt, int imm) : base("TGEIU", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
