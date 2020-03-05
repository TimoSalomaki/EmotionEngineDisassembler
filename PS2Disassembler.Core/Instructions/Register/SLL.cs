namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLL : RegisterBase
    {
        public SLL(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
