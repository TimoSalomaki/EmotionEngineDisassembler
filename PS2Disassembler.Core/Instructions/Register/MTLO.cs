namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTLO : RegisterBase
    {
        public MTLO(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MTLO", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
