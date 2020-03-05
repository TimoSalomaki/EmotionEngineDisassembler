namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBW : RegisterBase
    {
        public PSUBW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSUBW", rs, rt, rd, sa, funct)
        {
        }
    }
}
