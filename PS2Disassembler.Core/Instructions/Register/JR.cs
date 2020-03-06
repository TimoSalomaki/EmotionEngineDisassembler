namespace PS2Disassembler.Core.Instructions.Register
{
    public class JR : RegisterBase
    {
        public JR(uint rs, uint rt, uint rd, uint sa)
            : base("JR", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
