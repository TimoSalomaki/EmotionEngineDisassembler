namespace PS2Disassembler.Core.Instructions.Immediate.C790
{
    public class MTSAH : ImmediateBase
    {
        public MTSAH(uint rs, uint rt, uint imm) : base("MTSAH", rs, rt, imm)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {Imm}";
        }
    }
}
