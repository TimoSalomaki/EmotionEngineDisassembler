namespace PS2Disassembler.Core.Instructions.Register
{
    public class TGEU : RegisterBase
    {
        public TGEU(string rs, string rt, string rd, string sa, string funct)
            : base("TGEU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
