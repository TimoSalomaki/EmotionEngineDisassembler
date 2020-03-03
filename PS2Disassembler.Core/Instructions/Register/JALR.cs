namespace PS2Disassembler.Core.Instructions.Register
{
    public class JALR : RegisterBase
    {
        public JALR(int rs, int rt, int rd, int sa, int funct)
            : base("JALR", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}";
            //return $"{OP} {RS}"; // RD = 31 implied
        }
    }
}
