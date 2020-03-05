namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PINTEH : RegisterBase
    {
        public PINTEH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PINTEH", rs, rt, rd, sa, funct)
        {
        }
    }
}
