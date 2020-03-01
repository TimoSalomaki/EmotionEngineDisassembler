namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIV : RegisterBase
    {
        public DIV(string rs, string rt, string rd, string sa, string funct)
            : base("DIV", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
