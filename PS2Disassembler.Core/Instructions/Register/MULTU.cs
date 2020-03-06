namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULTU : RegisterBase
    {
        public MULTU(uint rs, uint rt, uint rd, uint sa)
            : base("MULTU", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
