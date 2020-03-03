namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRL : RegisterBase
    {
        public SRL(int rs, int rt, int rd, int sa, int funct)
            : base("SRL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
