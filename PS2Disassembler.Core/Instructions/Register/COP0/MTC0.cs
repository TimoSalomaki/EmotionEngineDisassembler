namespace PS2Disassembler.Core.Instructions.Register.COP0
{
    public class MTC0 : RegisterBase
    {
        public MTC0(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MTC0", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RT}, {RD}";
        }
    }
}
