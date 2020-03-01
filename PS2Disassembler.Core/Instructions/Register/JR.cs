namespace PS2Disassembler.Core.Instructions.Register
{
    public class JR : RegisterBase
    {
        public JR(string rs, string rt, string rd, string sa, string funct)
            : base("JR", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
