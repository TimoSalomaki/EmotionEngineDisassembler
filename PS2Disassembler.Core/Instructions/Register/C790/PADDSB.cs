namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PADDSB : RegisterBase
    {
        public PADDSB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PADDSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
