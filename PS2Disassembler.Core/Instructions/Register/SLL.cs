namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLL : RegisterBase
    {
        public SLL(uint rs, uint rt, uint rd, uint sa)
            : base("SLL", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
