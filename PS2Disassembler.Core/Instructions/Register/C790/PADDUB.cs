namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUB : RegisterBase
    {
        public PADDUB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PADDUB", rs, rt, rd, sa, funct)
        {
        }
    }
}
