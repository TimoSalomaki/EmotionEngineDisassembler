namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PABSW : RegisterBase
    {
        public PABSW(uint rs, uint rt, uint rd, uint sa) 
            : base("PABSW", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
