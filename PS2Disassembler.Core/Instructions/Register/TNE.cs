namespace PS2Disassembler.Core.Instructions.Register
{
    public class TNE : RegisterBase
    {
        public TNE(int rs, int rt, int rd, int sa, int funct)
            : base("TNE", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
