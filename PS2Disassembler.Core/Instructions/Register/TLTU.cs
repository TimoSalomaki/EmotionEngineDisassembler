namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLTU : RegisterBase
    {
        public TLTU(int rs, int rt, int rd, int sa, int funct)
            : base("TLTU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
