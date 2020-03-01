namespace PS2Disassembler.Core.Instructions.Register
{
    public class XOR : RegisterBase
    {
        public XOR(string rs, string rt, string rd, string sa, string funct)
            : base("XOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
