namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRAV : RegisterBase
    {
        public SRAV(uint rs, uint rt, uint rd, uint sa)
            : base("SRAV", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
