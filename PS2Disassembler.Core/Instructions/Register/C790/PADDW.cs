namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDW : RegisterBase
    {
        public PADDW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PADDW", rs, rt, rd, sa, funct)
        {
        }
    }
}
