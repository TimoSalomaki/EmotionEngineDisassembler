namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPAC5 : RegisterBase
    {
        public PPAC5(uint rs, uint rt, uint rd, uint sa) 
            : base("PPAC5", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
