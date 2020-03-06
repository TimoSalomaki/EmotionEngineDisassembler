namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIVU : RegisterBase
    {
        public DIVU(uint rs, uint rt, uint rd, uint sa)
            : base("DIVU", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
