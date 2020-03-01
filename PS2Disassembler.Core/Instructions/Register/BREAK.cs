namespace PS2Disassembler.Core.Instructions.Register
{
    public class BREAK : RegisterBase
    {
        public BREAK(string rs, string rt, string rd, string sa, string funct)
            : base("BREAK", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return "break";
        }
    }
}
