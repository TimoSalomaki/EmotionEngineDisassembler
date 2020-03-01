namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTLO : RegisterBase
    {
        public MTLO(string rs, string rt, string rd, string sa, string funct)
            : base("MTLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
