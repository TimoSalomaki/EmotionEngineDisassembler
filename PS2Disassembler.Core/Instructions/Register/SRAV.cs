namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRAV : RegisterBase
    {
        public SRAV(int rs, int rt, int rd, int sa, int funct)
            : base("SRAV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
