namespace PS2Disassembler.Core.Instructions.Register
{
    public class XOR : RegisterBase
    {
        public XOR(uint rs, uint rt, uint rd, uint sa)
            : base("XOR", rs, rt, rd, sa)
        {
        }
    }
}
