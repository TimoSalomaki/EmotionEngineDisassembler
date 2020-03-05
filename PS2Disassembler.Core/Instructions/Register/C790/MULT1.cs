namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class MULT1 : RegisterBase
    {
        public MULT1(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("MULT1", rs, rt, rd, sa, funct)
        {
        }
    }
}
