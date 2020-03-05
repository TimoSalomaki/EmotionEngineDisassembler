namespace PS2Disassembler.Core.Instructions.Register
{
    public class MTHI : RegisterBase
    {
        public MTHI(uint rs, uint rt, uint rd, uint sa, uint funct)
            : base("MTHI", rs, rt, rd, sa, funct)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
