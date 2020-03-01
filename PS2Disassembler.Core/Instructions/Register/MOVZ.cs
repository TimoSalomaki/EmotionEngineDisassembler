namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVZ : RegisterBase
    {
        public MOVZ(string rs, string rt, string rd, string sa, string funct)
            : base("MOVZ", rs, rt, rd, sa, funct)
        {
        }
    }
}
