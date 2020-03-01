namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUBU : RegisterBase
    {
        public SUBU(string rs, string rt, string rd, string sa, string funct)
            : base("SUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
