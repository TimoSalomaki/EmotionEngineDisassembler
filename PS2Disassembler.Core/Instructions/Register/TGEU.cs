namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGEU : RegisterBase
    {
        public TGEU(uint rs, uint rt, uint rd, uint sa)
            : base("TGEU", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
