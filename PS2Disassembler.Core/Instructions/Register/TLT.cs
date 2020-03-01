namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLT : RegisterBase
    {
        public TLT(string rs, string rt, string rd, string sa, string funct)
            : base("TLT", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
