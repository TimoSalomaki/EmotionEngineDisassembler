namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TLTI : ImmediateBase
    {
        public TLTI()
        {
            OP = "TLTI";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
