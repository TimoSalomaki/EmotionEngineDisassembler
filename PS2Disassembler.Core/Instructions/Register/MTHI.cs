namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTHI : RegisterBase
    {
        public MTHI(string rs, string rt, string rd, string sa, string funct)
            : base("MTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
