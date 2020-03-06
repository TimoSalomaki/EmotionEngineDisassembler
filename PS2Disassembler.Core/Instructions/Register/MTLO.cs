namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTLO : RegisterBase
    {
        public MTLO(uint rs, uint rt, uint rd, uint sa)
            : base("MTLO", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
