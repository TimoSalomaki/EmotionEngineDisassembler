namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLT : RegisterBase
    {
        public TLT(int rs, int rt, int rd, int sa, int funct)
            : base("TLT", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
