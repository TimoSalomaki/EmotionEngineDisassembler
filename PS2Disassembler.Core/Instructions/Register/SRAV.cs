namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRAV : RegisterBase
    {
        public SRAV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SRAV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
