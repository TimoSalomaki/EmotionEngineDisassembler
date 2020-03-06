namespace PS2Disassembler.Core.Instructions.Register
{
    public class TEQ : RegisterBase
    {
        public TEQ(uint rs, uint rt, uint rd, uint sa)
            : base("TEQ", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
