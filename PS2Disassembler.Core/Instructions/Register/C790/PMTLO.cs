namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMTLO : RegisterBase
    {
        public PMTLO(uint rs, uint rt, uint rd, uint sa) 
            : base("PMTLO", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
