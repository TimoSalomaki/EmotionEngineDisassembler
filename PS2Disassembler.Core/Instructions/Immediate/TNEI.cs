namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TNEI : ImmediateBase
    {
        public TNEI()
        {
            OP = "TNEI";
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
