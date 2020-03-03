namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTHI : RegisterBase
    {
        public MTHI(int rs, int rt, int rd, int sa, int funct)
            : base("MTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
