namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVZ : RegisterBase
    {
        public MOVZ(uint rs, uint rt, uint rd, uint sa)
            : base("MOVZ", rs, rt, rd, sa)
        {
        }
    }
}
