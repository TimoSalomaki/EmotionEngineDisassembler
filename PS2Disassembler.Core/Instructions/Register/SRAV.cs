namespace PS2Disassembler.Core.Instructions.Register
{
    public class SRAV : RegisterBase
    {
        public SRAV(string rs, string rt, string rd, string sa, string funct)
            : base("SRAV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
