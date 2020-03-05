namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLT : RegisterBase
    {
        public TLT(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("TLT", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
