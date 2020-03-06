namespace PS2Disassembler.Core.Instructions.Register
{
    public class BREAK : RegisterBase
    {
        public BREAK(uint rs, uint rt, uint rd, uint sa)
            : base("BREAK", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return "break";
        }
    }
}
