namespace PS2Disassembler.Core.Instructions.Register
{
    public class ADDU : RegisterBase
    {
        public ADDU(string rs, string rt, string rd, string sa, string funct)
            : base("ADDU", rs, rt, rd, sa, funct)
        {
        }
    }
}
