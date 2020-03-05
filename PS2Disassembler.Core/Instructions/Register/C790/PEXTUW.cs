namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PEXTUW : RegisterBase
    {
        public PEXTUW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PEXTUW", rs, rt, rd, sa, funct)
        {
        }
    }
}
