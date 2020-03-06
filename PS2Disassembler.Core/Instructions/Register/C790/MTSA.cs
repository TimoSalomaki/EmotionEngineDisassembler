namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTSA : RegisterBase
    {
        public MTSA(uint rs, uint rt, uint rd, uint sa) 
            : base("MTSA", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
