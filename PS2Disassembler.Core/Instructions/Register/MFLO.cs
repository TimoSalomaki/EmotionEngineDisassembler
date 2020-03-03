namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFLO : RegisterBase
    {
        public MFLO(int rs, int rt, int rd, int sa, int funct)
            : base("MFLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
