namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLT : RegisterBase
    {
        public SLT(string rs, string rt, string rd, string sa, string funct)
            : base("SLT", rs, rt, rd, sa, funct)
        {
        }
    }
}
