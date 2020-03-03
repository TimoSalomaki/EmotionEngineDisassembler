namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRA : RegisterBase
    {
        public SRA(int rs, int rt, int rd, int sa, int funct)
            : base("SRA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT} {SA}";
        }
    }
}
