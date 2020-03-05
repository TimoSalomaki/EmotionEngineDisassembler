namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PMULTH : RegisterBase
    {
        public PMULTH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PMULTH", rs, rt, rd, sa, funct)
        {
        }
    }
}
