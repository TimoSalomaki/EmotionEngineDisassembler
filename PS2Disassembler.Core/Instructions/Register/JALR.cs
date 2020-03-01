namespace PS2Disassembler.Core.Instructions.Register
{
    public class JALR : RegisterBase
    {
        public JALR(string rs, string rt, string rd, string sa, string funct)
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
