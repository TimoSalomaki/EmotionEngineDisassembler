namespace PS2Disassembler.Core.Instructions.Register
{
    public class NOR : RegisterBase
    {
        public NOR(string rs, string rt, string rd, string sa, string funct)
            : base("NOR", rs, rt, rd, sa, funct)
        {
        }
    }
}
