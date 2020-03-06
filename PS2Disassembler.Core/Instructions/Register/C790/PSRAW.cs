namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAW : RegisterBase
    {
        public PSRAW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSRAW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {SA}";
        }
    }
}
