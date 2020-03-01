namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRA : RegisterBase
    {
        public SRA(string rs, string rt, string rd, string sa, string funct)
            : base("SRA", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT} {SA}";
        }
    }
}
