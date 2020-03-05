namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACH : RegisterBase
    {
        public PPACH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PPACH", rs, rt, rd, sa, funct)
        {
        }
    }
}
