namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSLLW : RegisterBase
    {
        public PSLLW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSLLW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
