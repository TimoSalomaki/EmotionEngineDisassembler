namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLTU : RegisterBase
    {
        public TLTU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("TLTU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
