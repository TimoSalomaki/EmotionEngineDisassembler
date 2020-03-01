namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLLV : RegisterBase
    {
        public SLLV(string rs, string rt, string rd, string sa, string funct)
            : base("SLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
