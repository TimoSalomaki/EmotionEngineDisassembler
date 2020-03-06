namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MTHI1 : RegisterBase
    {
        public MTHI1(uint rs, uint rt, uint rd, uint sa) 
            : base("MTHI1", rs, rt, rd, sa)
        {
        }

        public override string ToString()
        {
            return $"{OP} {RS}";
        }
    }
}
