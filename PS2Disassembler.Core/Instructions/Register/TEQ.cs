namespace PS2Disassembler.Core.Instructions.Register
{
    public class TEQ : RegisterBase
    {
        public TEQ(int rs, int rt, int rd, int sa, int funct)
            : base("TEQ", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
