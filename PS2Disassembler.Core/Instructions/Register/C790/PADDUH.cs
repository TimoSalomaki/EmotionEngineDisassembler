namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUH : RegisterBase
    {
        public PADDUH(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDUH", rs, rt, rd, sa)
        {
        }
    }
}
