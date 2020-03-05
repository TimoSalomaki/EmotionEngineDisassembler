namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRLV : RegisterBase
    {
        public SRLV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
