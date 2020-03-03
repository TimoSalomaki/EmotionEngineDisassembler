namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFHI : RegisterBase
    {
        public MFHI(int rs, int rt, int rd, int sa, int funct)
            : base("MFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
