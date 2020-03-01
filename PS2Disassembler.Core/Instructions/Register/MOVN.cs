namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVN : RegisterBase
    {
        public MOVN(string rs, string rt, string rd, string sa, string funct)
            : base("MOVN", rs, rt, rd, sa, funct)
        {
        }
    }
}
