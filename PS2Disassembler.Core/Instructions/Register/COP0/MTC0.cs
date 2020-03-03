namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTC0 : RegisterBase
    {
        public MTC0(int rs, int rt, int rd, int sa, int funct)
            : base("MTC0", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RD}";
        }
    }
}
