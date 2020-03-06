namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MFSA : RegisterBase
    {
        public MFSA(uint rs, uint rt, uint rd, uint sa) 
            : base("MFSA", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RD}";
        }
    }
}
