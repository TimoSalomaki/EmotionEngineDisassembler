namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFHI : RegisterBase
    {
        public MFHI(string rs, string rt, string rd, string sa, string funct)
            : base("MFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
