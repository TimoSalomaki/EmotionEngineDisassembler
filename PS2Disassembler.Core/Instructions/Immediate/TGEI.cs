namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TGEI : ImmediateBase
    {
        public TGEI()
        {
            OP = "TGEI";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
