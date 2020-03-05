namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTUW : RegisterBase
    {
        public PMULTUW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMULTUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
