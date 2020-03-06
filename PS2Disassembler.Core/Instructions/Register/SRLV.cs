namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRLV : RegisterBase
    {
        public SRLV(uint rs, uint rt, uint rd, uint sa)
            : base("SRLV", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
