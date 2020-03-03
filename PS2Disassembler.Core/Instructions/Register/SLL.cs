namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLL : RegisterBase
    {
        public SLL(int rs, int rt, int rd, int sa, int funct)
            : base("SLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
