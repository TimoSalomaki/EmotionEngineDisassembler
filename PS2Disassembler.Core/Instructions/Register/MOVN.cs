namespace PS2Disassembler.Core.Instructions.Register
{
    public class MOVN : RegisterBase
    {
        public MOVN(uint rs, uint rt, uint rd, uint sa)
            : base("MOVN", rs, rt, rd, sa)
        {
        }
    }
}
