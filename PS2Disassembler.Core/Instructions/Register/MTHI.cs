namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTHI : RegisterBase
    {
        public MTHI(uint rs, uint rt, uint rd, uint sa)
            : base("MTHI", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
