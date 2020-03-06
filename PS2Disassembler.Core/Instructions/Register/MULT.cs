namespace PS2Disassembler.Core.Instructions.Register
{
    public class MULT : RegisterBase
    {
        public MULT(uint rs, uint rt, uint rd, uint sa)
            : base("MULT", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}, {RT}";
        }
    }
}
