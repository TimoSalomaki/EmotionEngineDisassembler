namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGEU : RegisterBase
    {
        public TGEU(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("TGEU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
