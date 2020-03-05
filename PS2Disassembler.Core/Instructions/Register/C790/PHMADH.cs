namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PHMADH : RegisterBase
    {
        public PHMADH(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PHMADH", rs, rt, rd, sa, funct)
        {
        }
    }
}
