namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIVU : RegisterBase
    {
        public DIVU(int rs, int rt, int rd, int sa, int funct)
            : base("DIVU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
