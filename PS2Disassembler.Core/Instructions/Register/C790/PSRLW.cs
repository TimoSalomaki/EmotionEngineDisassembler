namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLW : RegisterBase
    {
        public PSRLW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSRLW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
