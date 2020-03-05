namespace PS2Disassembler.Core.Instructions.Immediate
{
    public class TEQI : ImmediateBase
    {
        public TEQI(uint rs, uint rt, uint imm) : base("TEQI", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
