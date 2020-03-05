namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIV : RegisterBase
    {
        public DIV(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("DIV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
