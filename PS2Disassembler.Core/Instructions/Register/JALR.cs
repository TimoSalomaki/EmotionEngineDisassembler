namespace PS2Disassembler.Core.Instructions.Register
{
    public class JALR : RegisterBase
    {
        public JALR(uint rs, uint rt, uint rd, uint sa)
            : base("JALR", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RS}";
            //return $"{OP} {RS}"; // RD = 31 implied
        }
    }
}
