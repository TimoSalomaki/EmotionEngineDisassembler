namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDW : RegisterBase
    {
        public PADDW(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDW", rs, rt, rd, sa)
        {
        }
    }
}
