namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADD : RegisterBase
    {
        public DADD(string rs, string rt, string rd, string sa, string funct)
            : base("DADD", rs, rt, rd, sa, funct)
        {
        }
    }
}
