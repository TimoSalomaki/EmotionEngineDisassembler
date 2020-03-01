namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLL : RegisterBase
    {
        public SLL(string rs, string rt, string rd, string sa, string funct)
            : base("SLL", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
