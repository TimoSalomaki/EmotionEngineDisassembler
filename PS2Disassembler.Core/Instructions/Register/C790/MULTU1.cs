namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULTU1 : RegisterBase
    {
        public MULTU1(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MULTU1", rs, rt, rd, sa, funct)
        {
        }
    }
}
