namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCGTH : RegisterBase
    {
        public PCGTH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCGTH", rs, rt, rd, sa, funct)
        {
        }
    }
}
