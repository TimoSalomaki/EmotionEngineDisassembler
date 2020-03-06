namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PREVH : RegisterBase
    {
        public PREVH(uint rs, uint rt, uint rd, uint sa) 
            : base("PREVH", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
