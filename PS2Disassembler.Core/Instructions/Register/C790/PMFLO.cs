namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMFLO : RegisterBase
    {
        public PMFLO(uint rs, uint rt, uint rd, uint sa) 
            : base("PMFLO", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
