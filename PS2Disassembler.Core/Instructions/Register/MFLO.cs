namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFLO : RegisterBase
    {
        public MFLO(string rs, string rt, string rd, string sa, string funct)
            : base("MFLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
