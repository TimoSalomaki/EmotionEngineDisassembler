namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLTU : RegisterBase
    {
        public SLTU(string rs, string rt, string rd, string sa, string funct)
            : base("SLTU", rs, rt, rd, sa, funct)
        {
        }
    }
}
