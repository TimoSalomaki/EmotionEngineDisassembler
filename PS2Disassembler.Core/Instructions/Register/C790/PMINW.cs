namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMINW : RegisterBase
    {
        public PMINW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMINW", rs, rt, rd, sa, funct)
        {
        }
    }
}
