namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCW : RegisterBase
    {
        public PEXCW(uint rs, uint rt, uint rd, uint sa) 
            : base("PEXCW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
