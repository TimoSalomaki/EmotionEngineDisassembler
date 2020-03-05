namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMSUBH : RegisterBase
    {
        public PMSUBH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMSUBH", rs, rt, rd, sa, funct)
        {
        }
    }
}
