namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGEU : RegisterBase
    {
        public TGEU(int rs, int rt, int rd, int sa, int funct)
            : base("TGEU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
