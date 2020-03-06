namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFHI1 : RegisterBase
    {
        public MFHI1(uint rs, uint rt, uint rd, uint sa) 
            : base("MFHI1", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
