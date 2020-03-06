namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSRAVW : RegisterBase
    {
        public PSRAVW(uint rs, uint rt, uint rd, uint sa) 
            : base("PSRAVW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}, {RS}";
        }
    }
}
