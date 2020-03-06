namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSH : RegisterBase
    {
        public PADDSH(uint rs, uint rt, uint rd, uint sa) 
            : base("PADDSH", rs, rt, rd, sa)
        {
        }
    }
}
