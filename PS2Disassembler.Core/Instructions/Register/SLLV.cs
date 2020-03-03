namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLLV : RegisterBase
    {
        public SLLV(int rs, int rt, int rd, int sa, int funct)
            : base("SLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
