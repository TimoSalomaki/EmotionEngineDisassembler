namespace PS2Disassembler.Core.Instructions.Register
{
    public class TEQ : RegisterBase
    {
        public TEQ(string rs, string rt, string rd, string sa, string funct)
            : base("TEQ", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
