namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRLV : RegisterBase
    {
        public SRLV(string rs, string rt, string rd, string sa, string funct)
            : base("SRLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
