namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFHI : RegisterBase
    {
        public MFHI(uint rs, uint rt, uint rd, uint sa)
            : base("MFHI", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
