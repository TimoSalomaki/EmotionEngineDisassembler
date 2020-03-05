namespace PS2Disassembler.Core.Instructions.Register.C790
{
    public class PSUBSB : RegisterBase
    {
        public PSUBSB(uint rs, uint rt, uint rd, uint sa, uint funct) 
            : base("PSUBSB", rs, rt, rd, sa, funct)
        {
        }
    }
}
