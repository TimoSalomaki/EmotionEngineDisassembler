namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIV : RegisterBase
    {
        public DIV(int rs, int rt, int rd, int sa, int funct)
            : base("DIV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
