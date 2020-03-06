namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRA : RegisterBase
    {
        public SRA(uint rs, uint rt, uint rd, uint sa)
            : base("SRA", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT} {SA}";
        }
    }
}
