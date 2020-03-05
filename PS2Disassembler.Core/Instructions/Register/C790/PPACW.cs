namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PPACW : RegisterBase
    {
        public PPACW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PPACW", rs, rt, rd, sa, funct)
        {
        }
    }
}
