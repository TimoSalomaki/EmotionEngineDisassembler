namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXCH : RegisterBase
    {
        public PEXCH(uint rs, uint rt, uint rd, uint sa) 
            : base("PEXCH", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}, {RT}";
        }
    }
}
