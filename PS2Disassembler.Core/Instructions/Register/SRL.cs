namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRL : RegisterBase
    {
        public SRL(uint rs, uint rt, uint rd, uint sa)
            : base("SRL", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
