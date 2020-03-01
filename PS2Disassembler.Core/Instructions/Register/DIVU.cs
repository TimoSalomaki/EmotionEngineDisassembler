namespace PS2Disassembler.Core.Instructions.Register
{
    public class DIVU : RegisterBase
    {
        public DIVU(string rs, string rt, string rd, string sa, string funct)
            : base("DIVU", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
