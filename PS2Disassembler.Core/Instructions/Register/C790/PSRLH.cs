namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRLH : RegisterBase
    {
        public PSRLH(uint rs, uint rt, uint rd, uint sa) 
            : base("PSRLH", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
