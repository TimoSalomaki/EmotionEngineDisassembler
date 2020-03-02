namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class MTSAB : ImmediateBase
    {
        public MTSAB(string rs, string rt, short imm) : base("MTSAB", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
