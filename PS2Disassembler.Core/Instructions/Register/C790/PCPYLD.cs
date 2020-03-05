namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PCPYLD : RegisterBase
    {
        public PCPYLD(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PCPYLD", rs, rt, rd, sa, funct)
        {
        }
    }
}
