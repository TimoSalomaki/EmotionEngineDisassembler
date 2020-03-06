namespace PS2Disassembler.Core.Instructions.Register
{
    public class TLTU : RegisterBase
    {
        public TLTU(uint rs, uint rt, uint rd, uint sa)
            : base("TLTU", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
