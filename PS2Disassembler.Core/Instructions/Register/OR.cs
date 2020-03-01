namespace PS2Disassembler.Core.Instructions.Register
{
    public class OR : RegisterBase
    {
        public OR(string rs, string rt, string rd, string sa, string funct)
            : base("OR", rs, rt, rd, sa, funct)
        {
        }
    }
}
