namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRLV : RegisterBase
    {
        public SRLV(int rs, int rt, int rd, int sa, int funct)
            : base("SRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
