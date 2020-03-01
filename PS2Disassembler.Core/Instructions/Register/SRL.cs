namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRL : RegisterBase
    {
        public SRL(string rs, string rt, string rd, string sa, string funct)
            : base("SRL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
