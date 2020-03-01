namespace PS2Disassembler.Core.Instructions.Register
{
    public class DSUBU : RegisterBase
    {
        public DSUBU(string rs, string rt, string rd, string sa, string funct)
            : base("DSUBU", rs, rt, rd, sa, funct)
        {
        }
    }
}
