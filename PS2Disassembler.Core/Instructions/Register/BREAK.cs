namespace PS2Disassembler.Core.Instructions.Register
{
    public class BREAK : RegisterBase
    {
        public BREAK(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("BREAK", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "break";
        }
    }
}
