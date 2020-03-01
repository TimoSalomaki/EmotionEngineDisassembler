namespace PS2Disassembler.Core.Instructions.Register
{
    public class AND : RegisterBase
    {
        public AND(string rs, string rt, string rd, string sa, string funct)
            : base("AND", rs, rt, rd, sa, funct)
        {
        }
    }
}
