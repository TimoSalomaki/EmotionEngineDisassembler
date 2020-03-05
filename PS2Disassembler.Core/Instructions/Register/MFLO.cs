namespace PS2Disassembler.Core.Instructions.Register
{
    public class MFLO : RegisterBase
    {
        public MFLO(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MFLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
