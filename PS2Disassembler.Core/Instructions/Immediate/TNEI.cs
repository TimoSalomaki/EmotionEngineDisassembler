namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TNEI : ImmediateBase
    {
        public TNEI(string rs, string rt, short imm) : base("TNEI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
