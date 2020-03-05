namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PINTH : RegisterBase
    {
        public PINTH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PINTH", rs, rt, rd, sa, funct)
        {
        }
    }
}
