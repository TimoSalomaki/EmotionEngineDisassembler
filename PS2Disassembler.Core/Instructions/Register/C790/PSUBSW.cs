namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSW : RegisterBase
    {
        public PSUBSW(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSUBSW", rs, rt, rd, sa, funct)
        {
        }
    }
}
