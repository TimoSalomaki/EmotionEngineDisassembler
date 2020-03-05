namespace PS2Disassembler.Core.Instructions.Register
{
    public class JR : RegisterBase
    {
        public JR(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("JR", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
