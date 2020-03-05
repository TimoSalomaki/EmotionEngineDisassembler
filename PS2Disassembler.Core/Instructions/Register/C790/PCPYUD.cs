namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYUD : RegisterBase
    {
        public PCPYUD(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCPYUD", rs, rt, rd, sa, funct)
        {
        }
    }
}
