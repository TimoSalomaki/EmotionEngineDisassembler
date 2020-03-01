namespace PS2Disassembler.Core.Instructions.Register
{
    public class DADDU : RegisterBase
    {
        public DADDU(string rs, string rt, string rd, string sa, string funct)
            : base("DADDU", rs, rt, rd, sa, funct)
        {
        }
    }
}
