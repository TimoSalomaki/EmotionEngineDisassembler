namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLT : RegisterBase
    {
        public TLT(uint rs, uint rt, uint rd, uint sa)
            : base("TLT", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
