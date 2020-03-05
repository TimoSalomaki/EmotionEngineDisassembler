namespace PS2Disassembler.Core.Instructions.Register
{
    public class SLLV : RegisterBase
    {
        public SLLV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("SLLV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
