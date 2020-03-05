namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDUW : RegisterBase
    {
        public PADDUW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PADDUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
