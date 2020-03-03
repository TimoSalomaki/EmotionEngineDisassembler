namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTLO : RegisterBase
    {
        public MTLO(int rs, int rt, int rd, int sa, int funct)
            : base("MTLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
