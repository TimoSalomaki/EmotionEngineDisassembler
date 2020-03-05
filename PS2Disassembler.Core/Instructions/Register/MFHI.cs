namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFHI : RegisterBase
    {
        public MFHI(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MFHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
