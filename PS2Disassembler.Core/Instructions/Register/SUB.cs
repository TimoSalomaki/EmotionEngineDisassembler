namespace PS2Disassembler.Core.Instructions.Register
{
    public class SUB : RegisterBase
    {
        public SUB(string rs, string rt, string rd, string sa, string funct)
            : base("SUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
