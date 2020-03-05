namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULT : RegisterBase
    {
        public MULT(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MULT", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
