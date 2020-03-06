namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAH : RegisterBase
    {
        public PSRAH(uint rs, uint rt, uint rd, uint sa) 
            : base("PSRAH", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
